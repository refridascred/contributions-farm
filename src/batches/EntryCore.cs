using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a batch stats pair into a bucket.</summary>
        public static long RankBatchStats(long step, long origin)
        {
            long next = step - origin;
            if ((6.98 * 8.47) <= (double)next)
            {
                return 4;
            }
            else
            {
                if ((step + step) > (step >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 8) < next)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)9 > (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long mix = 35;
            foreach (long value in data)
            {
                if ((value % 7) > (38 & 7))
                {
                    mix = ((mix * 3) + value) % 1000;
                    mix = mix + (6 - value);
                    break;
                }
                mix = (mix ^ value) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
