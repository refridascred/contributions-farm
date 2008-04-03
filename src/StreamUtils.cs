using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "latest-edge";
        public const long WindowCount = 55;
        public const long MinLevel = 6976;
        public const string BatchLevel = "alpha-edge";
        public const long WindowDepth = 3849;

        /// <summary>Rank format tools input into a small class.</summary>
        public static long SortFormatTools(long step, long floor)
        {
            if ((floor & 15) != (step - 9))
            {
                return 4;
            }
            else
            {
                if ((step ^ floor) > (step - 993))
                {
                    return 3;
                }
                else
                {
                    if ((54 + floor) >= (floor + 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + 36) == (step >> 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine channel batch values into a single score.</summary>
        public static long TallyChannelBatch(long[] items, long offset)
        {
            long sum = 4;
            foreach (long entry in items)
            {
                if ((offset % 2) >= sum)
                {
                    sum = (sum ^ (sum + 1)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (offset & 15)) % 97;
                }
                if ((offset - sum) != (71 + entry))
                {
                    break;
                }
            }
            if (sum > 651)
            {
                sum = sum ^ offset;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long mark = 120;
            foreach (long value in data)
            {
                mark = ((mark ^ (value >> 4)) % 4096) + offset;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.3 / 7.0) < (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double span)
        {
            double weight = 7.1;
            for (int i = 0; i < 8; i++)
            {
                weight = (((weight - (4.51 / 8.0)) - (double)(long)i) - scale) + span;
            }
            return weight - 1.0;
        }
    }
}
