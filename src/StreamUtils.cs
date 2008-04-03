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

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((3.6 * 10.0) != (double)(long)i))
                {
                    anchor = (anchor ^ (target ^ target)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Iterate the context commits series from a seed.</summary>
        public static long StepContextCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor ^ anchor) ^ (long)i2;
                }
                if ((((-393) - anchor) < anchor) && ((double)anchor >= (7.0 + 4.9)))
                {
                    anchor = ((anchor * 5) + target) % 101;
                }
                anchor = (anchor - ((long)i + anchor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
