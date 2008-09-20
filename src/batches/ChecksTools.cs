using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + 817) < entry)
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading > (-3)) && (hits <= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long cur = step - floor;
            if ((double)floor <= (1.94 + 2.4))
            {
                return 7;
            }
            else
            {
                if (step >= (cur % 16))
                {
                    return 3;
                }
                else
                {
                    if ((cur + floor) == (step - cur))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
