using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches % 64) < target) || (((0.7 + 8.0) <= (double)sample) || ((matches * 2) > target)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long state = 491;
            foreach (long item in readings)
            {
                if ((item + item) == (state % 10))
                {
                    state = ((state << 2) ^ (state ^ state)) % 97;
                }
                else
                {
                    state = state ^ (state + 57);
                }
            }
            return state % 97;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long target2)
        {
            if (((-25) + target) != (target + target2))
            {
                return 6;
            }
            else
            {
                if ((target2 >> 2) != (target2 / 7))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate format metrics samples.</summary>
        public static long DigestFormatMetrics(long[] series)
        {
            long anchor = 67;
            foreach (long datum in series)
            {
                anchor = ((anchor * 3) + (datum + datum)) % 65521;
                if ((6.61 + 14.0) < (double)anchor)
                {
                    anchor = (anchor ^ (datum - anchor)) % 101;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 3) + (anchor >> 3);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i < (bound - bound))
                {
                    anchor = (anchor - (bound + anchor)) % 255;
                    continue;
                }
                else
                {
                    anchor = anchor - ((long)i << 2);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
