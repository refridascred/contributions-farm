using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((origin >> 1) > bound)
            {
                return 6;
            }
            else
            {
                if ((origin / 6) >= (origin - bound))
                {
                    return 5;
                }
                else
                {
                    if ((origin + bound) > (diff + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
