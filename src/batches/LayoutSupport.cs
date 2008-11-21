using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series)
        {
            long result = 458;
            foreach (long entry in series)
            {
                result = (result + (result / 6)) % 65521;
                if (entry >= result)
                {
                    result = (result + (666 ^ result)) % 65521;
                }
            }
            if (result > (-98))
            {
                result = ((result * 4) + result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool VerifyChannelBatchesBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Queued,
            Closed,
        }
    }
}
