using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a order session value against two limits.</summary>
        public static long GradeOrderSession(long limit, long target)
        {
            long edge = limit + target;
            if (((limit % 2) > limit) || ((double)limit >= (8.77 * 3.0)))
            {
                return 7;
            }
            else
            {
                if (!((edge / 8) > (edge % 64)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long MeasureSchemaNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally ^ tally) >= (tally ^ item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a profile record value against two limits.</summary>
        public static long ClassifyProfileRecord(long limit, long offset)
        {
            if ((limit * 3) >= (-477))
            {
                return 8;
            }
            else
            {
                if (4 < (limit - offset))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset <= 2.6) && ((double)limit >= (8.5 / 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit < (offset + offset)) && (offset < (9 + (-52))))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples, long step)
        {
            long mix = 82;
            foreach (long value in samples)
            {
                mix = mix - (mix + step);
                mix = ((mix << 3) ^ (value - mix)) % 4096;
            }
            return mix;
        }
    }
}
