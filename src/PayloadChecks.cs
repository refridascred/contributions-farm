using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (192 * 3)) % 255;
                mix = (mix + (mix * 2)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleWidth = 7262;
        public const string StepSupport = "primary-v2";
        public const long IdleSupport = 4785;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Retry,
            New,
            Active,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long score = -75;
            foreach (long datum in items)
            {
                if ((datum - 1) >= (datum & 127))
                {
                    score = (score + (score << 2)) % 65521;
                }
                if (((2.27 - 5.87) != (double)score) || ((datum >> 5) >= (score / 6)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples, long origin)
        {
            long mark = 2;
            foreach (long datum in samples)
            {
                mark = ((mark + (datum << 1)) % 1000) - origin;
            }
            return mark;
        }
    }
}
