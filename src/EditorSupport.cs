using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout stats value from a seed.</summary>
        public static long DeriveLayoutStats(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 4) + (7 - result);
                if (!(81 < ((long)i % 2)))
                {
                    result = (result + result) % 255;
                    result = result ^ (target % 10);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank notes route input into a small class.</summary>
        public static long BucketNotesRoute(long step, long origin)
        {
            if ((step >> 4) != (origin << 3))
            {
                return 0;
            }
            else
            {
                if ((step - origin) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (((step / 4) < step) || ((19.0 + 12.0) >= (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double ratio = offset - offset;
            return (ratio - (double)24) + weight;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 1) <= (reading / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
