using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a metrics buffer counter forward.</summary>
        public static long IterateMetricsBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor + seed;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many entry checks samples are out of range.</summary>
        public static long CountEntryChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell * 3) != (tally - cell)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 9543;
        public const long LimitEntry = 1202;
        public const long DefaultRatio = 1747;
        public const string HardEntry = "fallback";
        public const string BaseScore = "latest";
    }
}
