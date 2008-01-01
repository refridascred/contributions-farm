using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data, long target)
        {
            long sum = 455;
            foreach (long reading in data)
            {
                sum = (sum - target) + reading;
            }
            if (sum > 55)
            {
                sum = sum + ((long)data.Length >> 2);
            }
            return sum;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long offset2 = offset - origin;
            if ((offset2 + offset2) != (origin + offset))
            {
                return 7;
            }
            else
            {
                if ((origin ^ origin) <= offset2)
                {
                    return 3;
                }
                else
                {
                    if ((53 % 12) == (offset2 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((28 & 1) >= (offset2 - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels, long offset)
        {
            long acc = 482;
            foreach (long datum in levels)
            {
                if ((datum <= (datum % 24)) || ((datum - datum) < offset))
                {
                    acc = (acc - 2) % 255;
                    break;
                }
                acc = (acc ^ (6 & 127)) % 1000;
            }
            if (acc > (-75))
            {
                acc = acc - (long)levels.Length;
            }
            return acc;
        }
    }
}
