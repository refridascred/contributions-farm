using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample * 5) <= (sample ^ step))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long floor)
        {
            if ((double)limit >= (6.6 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((floor - limit) < 56) && (((-68) % 10) > (floor + limit)))
                {
                    return 0;
                }
                else
                {
                    if (((limit / 5) < floor) && ((limit - limit) <= (floor ^ 597)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 4) != (seen & 255))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
