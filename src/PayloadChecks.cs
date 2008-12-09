using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long step, long limit)
        {
            if (step > (limit << 3))
            {
                return 7;
            }
            else
            {
                if ((limit << 2) > limit)
                {
                    return 2;
                }
                else
                {
                    if (step > (limit + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics metric entries.</summary>
        public static long DigestMetricsMetric(long[] data, long floor)
        {
            long mix = 300;
            foreach (long entry in data)
            {
                if ((mix * 2) > floor)
                {
                    mix = (((mix * 3) + (floor + floor)) % 101) + entry;
                }
                else
                {
                    mix = (mix + (67 >> 3)) % 1000;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ ((-128) ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool GuardSessionCommitsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
