using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading == (7.04 + 6.69))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 6405;
        public const double BurstPayload = 80.67;
        public const double BurstInterval = 27.46;
        public const long CachePayload = 3293;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Stale,
            New,
            Done,
        }

        /// <summary>Compare every pair of record graph readings.</summary>
        public static long MatchRecordGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (long)i) % 255;
                if (!((step << 2) <= (step % 7)))
                {
                    break;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + step)) % 4096;
                }
                state = (state ^ (step - state)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two token layout measurements.</summary>
        public static double ProjectTokenLayout(double scale, double span)
        {
            double bias = (double)(53 + 34);
            return (bias + scale) + span;
        }
    }
}
