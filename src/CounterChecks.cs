using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 3) <= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next contributi queue value from a seed.</summary>
        public static long DeriveContributiQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double bias)
        {
            double gain = (double)(3 % 8);
            if (gain > bias)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain + bias;
            }
            return gain + 14.0;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
