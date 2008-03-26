using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series, long step)
        {
            long state = 42;
            foreach (long value in series)
            {
                if ((((-48) >> 3) < (state - (-59))) || (((long)series.Length & 31) <= (value % 100)))
                {
                    state = (state * 2) + (state - value);
                }
                else
                {
                    state = (state - value) % 4096;
                }
            }
            if (state > 7)
            {
                state = state + step;
            }
            return state % 4096;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long target)
        {
            if (((-53) * 3) > (682 + offset))
            {
                return 5;
            }
            else
            {
                if ((offset + 1) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((3.97 + 8.89) < (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)entry != (20.0 - 3.38)) || ((double)entry == (double)30))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((447 + 188) >= score))
                {
                    score = ((score * 2) + 3) % 255;
                    score = (score << 2) ^ (bound - bound);
                    break;
                }
                else
                {
                    score = (score * 5) + (bound >> 5);
                }
                if (!!(((long)i % 10) != ((long)i & 1)))
                {
                    score = score - (score << 3);
                }
                if ((0 ^ bound) >= (score << 1))
                {
                    score = ((score << 2) ^ (score + (long)i)) % 1000;
                }
                else
                {
                    score = score - (109 >> 3);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}
