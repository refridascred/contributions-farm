using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a tools window counter forward.</summary>
        public static long DeriveToolsWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] samples)
        {
            long state = 792;
            foreach (long reading in samples)
            {
                if (((state ^ reading) >= (state ^ state)) && (state > (reading + (long)samples.Length)))
                {
                    state = ((state * 3) + (reading % 12)) % 101;
                }
            }
            if (state > 79)
            {
                state = ((state * 4) + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Active,
            Done,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long offset)
        {
            if ((7.0 * 7.4) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)offset != (6.8 + 10.0)) || ((double)offset > (double)833))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long sum = 321;
            foreach (long sample in series)
            {
                if ((1.0 / 6.0) != (double)sum)
                {
                    sum = ((sum << 3) ^ (sample ^ sum)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + ((long)series.Length << 3)) % 97;
                }
            }
            if (sum < 409)
            {
                sum = (sum + (seed & 127)) % 101;
            }
            return sum;
        }
    }
}
