using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowSpan = "alpha-1";
        public const double BatchCache = 89.97;
        public const long MinCache = 8632;
        public const long BatchInterval = 3108;
        public const string LimitCache = "strict-v2";

        /// <summary>Adjust a record commits reading.</summary>
        public static double BlendRecordCommits(double ratio, double offset)
        {
            double bias = (double)(72 ^ 946);
            if (bias <= (ratio * 18.0))
            {
                bias = (bias - (double)598) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long target)
        {
            long edge = bound ^ target;
            if ((8 ^ target) > bound)
            {
                return 7;
            }
            else
            {
                if ((double)edge >= 3.4)
                {
                    return 4;
                }
                else
                {
                    if ((347 % 24) > (target + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound > (bound - bound)) && ((215 * 5) >= (bound << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
