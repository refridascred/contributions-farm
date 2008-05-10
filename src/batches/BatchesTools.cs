using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels, long limit)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if ((double)sample <= 0.34)
                {
                    mix = ((mix * 2) + (limit % 2)) % 101;
                }
                else
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            New,
            Closed,
            Active,
            Idle,
        }
    }
}
