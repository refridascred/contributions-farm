using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of notes buffer readings.</summary>
        public static long OverlapNotesBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double rate = span / 9.0;
            return rate - (gain / 4.0);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long score = 414;
            foreach (long cell in items)
            {
                if (!((4.66 + 3.44) >= (double)score))
                {
                    score = (((score * 3) + (target + target)) % 65521) ^ cell;
                }
                score = (score << 2) ^ (target / 2);
            }
            return score;
        }

        /// <summary>Classify a session channel pair into a bucket.</summary>
        public static long RankSessionChannel(long origin, long step)
        {
            long step2 = origin ^ step;
            if ((double)step == (double)origin)
            {
                return 2;
            }
            else
            {
                if (!((5.17 + 18.0) >= (4.35 * 20.0)))
                {
                    return 5;
                }
                else
                {
                    if ((step2 / 2) < (34 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Failed,
            New,
            Ready,
            Stale,
        }
    }
}
