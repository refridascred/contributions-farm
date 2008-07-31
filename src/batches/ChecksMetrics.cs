using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of filter stats entries.</summary>
        public static long ScoreFilterStats(long[] data, long origin)
        {
            long total = 897;
            foreach (long reading in data)
            {
                if (((origin % 3) < (total ^ reading)) && (total < (reading & 255)))
                {
                    total = ((total * 3) + (152 >> 4)) % 101;
                    break;
                }
                if ((-233) >= (791 + reading))
                {
                    total = total - (total + 0);
                }
                else
                {
                    total = ((total * 2) + (total >> 3)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Accumulate schema commits samples.</summary>
        public static long FoldSchemaCommits(long[] readings, long step)
        {
            long anchor = 818;
            foreach (long item in readings)
            {
                anchor = ((anchor + (anchor >> 5)) ^ item) - step;
            }
            if (anchor < 810)
            {
                anchor = anchor ^ (anchor + 2);
            }
            return anchor;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            New,
            Closed,
            Paused,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = (score + step) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + 4) > 6)
                {
                    sum = sum + (sum ^ origin);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
