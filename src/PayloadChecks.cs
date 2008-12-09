using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of commits order entries.</summary>
        public static long ScoreCommitsOrder(long[] items)
        {
            long total = -8;
            foreach (long entry in items)
            {
                if (!(total < (entry % 12)))
                {
                    total = total ^ 840;
                }
                if ((double)total < 5.3)
                {
                    total = (total ^ (total + entry)) % 255;
                }
                else
                {
                    total = ((total * 2) + (total & 7)) % 255;
                }
            }
            if (total > 464)
            {
                total = ((total * 5) + (3 + 40)) % 101;
            }
            return total;
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
