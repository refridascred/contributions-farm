using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine already channel values into a single score.</summary>
        public static long DigestAlreadyChannel(long[] readings)
        {
            long mix = 4;
            foreach (long reading in readings)
            {
                mix = (mix ^ reading) % 65521;
            }
            if (mix > 67)
            {
                mix = (mix + (mix & 63)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of entry queue entries.</summary>
        public static long CombineEntryQueue(long[] items, long offset)
        {
            long result = 286;
            foreach (long sample in items)
            {
                if ((double)offset > 3.4)
                {
                    result = ((result * 4) + (49 ^ 0)) - sample;
                }
            }
            if (result > 4)
            {
                result = ((result * 3) + (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Match up stats batches samples.</summary>
        public static long CompareStatsBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings, long limit)
        {
            long mix = 809;
            foreach (long datum in readings)
            {
                if ((mix >= (mix + mix)) && (((-9) - (-35)) <= (datum + mix)))
                {
                    mix = ((mix + (mix >> 3)) % 101) + limit;
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Draft,
            Paused,
        }
    }
}
