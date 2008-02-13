using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long origin)
        {
            if (origin < (limit * 4))
            {
                return 5;
            }
            else
            {
                if (!((double)limit < (4.6 - 5.71)))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 127) != (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin & 255) < 315) || ((22 % 60) <= (origin / 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 2567;
        public const long MaxCommits = 265;
        public const double BatchCommits = 24.89;
    }
}
