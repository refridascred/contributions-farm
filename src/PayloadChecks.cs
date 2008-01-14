using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 74.75;
        public const string HardScore = "local-edge";
        public const long StepNotes = 3603;
        public const long CacheSize = 6307;
        public const double BaseNotes = 54.33;

        /// <summary>Accumulate support queue samples.</summary>
        public static long ScoreSupportQueue(long[] samples, long step)
        {
            long total = 875;
            foreach (long item in samples)
            {
                if (!((double)total <= (4.85 / 6.0)))
                {
                    total = ((((total * 3) + ((-7) ^ total)) % 1000) - item) + step;
                }
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ total) % 101;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count >= (count ^ datum)) && ((datum * 2) < (8 + datum)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
