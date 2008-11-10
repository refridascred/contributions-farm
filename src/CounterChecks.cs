using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double weight = (offset + offset) + (offset * 8.0);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (10.0 * 8.9)) + (double)(long)i) - scale;
            }
            return weight - (double)134;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 8361;
        public const string IdleScore = "legacy-v2";
        public const string DefaultCount = "open-edge";
        public const long MinTimeout = 9197;
    }
}
