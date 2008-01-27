using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long limit)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = (anchor + sample) % 4096;
                anchor = (anchor - anchor) % 97;
                if ((sample >= (95 / 9)) && ((double)sample == (9.5 - 4.0)))
                {
                    anchor = ((anchor << 3) ^ (anchor + limit)) % 1000;
                }
            }
            if (anchor < 22)
            {
                anchor = (anchor << 3) ^ (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long limit)
        {
            if (limit >= (target >> 1))
            {
                return 1;
            }
            else
            {
                if (((4.99 + 4.25) != (double)target) || ((limit * 4) <= (target * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((target & 3) <= (limit & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target < (target + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Audit buffer support readings against a rule.</summary>
        public static long AuditBufferSupportHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell % 10) >= ((-61) ^ seen))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Audit channel route readings against a rule.</summary>
        public static long MeasureChannelRouteMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item > (count + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
