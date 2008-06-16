using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes editor counter forward.</summary>
        public static long RollNotesEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (score - offset)) % 97;
                if (offset <= (score - 374))
                {
                    score = score + (score * 2);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank cluster route input into a small class.</summary>
        public static long GradeClusterRoute(long step, long origin)
        {
            if (((double)step < (7.38 + 4.69)) || ((double)origin < (double)step))
            {
                return 4;
            }
            else
            {
                if (step >= (origin / 3))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) >= (origin - 37))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
