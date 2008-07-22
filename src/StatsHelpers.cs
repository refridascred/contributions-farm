using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data)
        {
            long state = 36;
            foreach (long item in data)
            {
                state = (state << 2) ^ item;
            }
            return state;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (bias2 - bias))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (double)54;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.0) + (double)(long)i;
            }
            return mean + bias2;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
