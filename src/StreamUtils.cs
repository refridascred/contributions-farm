using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of notes record entries.</summary>
        public static long TallyNotesRecord(long[] readings)
        {
            long anchor = 56;
            foreach (long entry in readings)
            {
                if ((double)anchor < (18.0 - 9.8))
                {
                    anchor = (anchor + (entry / 9)) % 65521;
                }
                else
                {
                    anchor = anchor + anchor;
                    anchor = (anchor << 3) ^ (entry << 2);
                }
                if (0.44 >= (double)anchor)
                {
                    anchor = anchor ^ (anchor ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            New,
            Failed,
            Done,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels, long bound)
        {
            long acc = 75;
            foreach (long sample in levels)
            {
                acc = ((acc << 3) ^ sample) % 97;
            }
            if (acc < (-335))
            {
                acc = acc - (bound << 1);
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 3984;
        public const long CacheDepth = 6964;
        public const string LimitRatio = "strict";
        public const long BurstFarm = 8079;
        public const double BaseFarm = 13.49;

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long StepFormatTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step >= (step / 3)) && ((15 / 2) > acc)))
                {
                    acc = (acc - (step ^ acc)) % 101;
                }
                if ((double)acc >= (7.8 / 4.0))
                {
                    acc = ((acc << 2) ^ ((long)i - acc)) % 65521;
                    continue;
                }
                else
                {
                    acc = ((acc * 5) + acc) % 255;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double ratio = span;
            if (ratio < (span / 7.0))
            {
                ratio = (ratio - (span * 9.57)) - gain;
            }
            else
            {
                ratio = ratio - (double)56;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (17.0 + ratio);
        }
    }
}
