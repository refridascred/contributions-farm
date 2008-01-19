using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowRatio = 5584;
        public const double CacheBuffer = 57.65;
        public const long MinSize = 9282;
        public const long IdleBuffer = 2166;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((1.21 - 6.0) > (double)seed)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            New,
            Ready,
        }
    }
}
