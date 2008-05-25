using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a queue contributi pair into a bucket.</summary>
        public static long SortQueueContributi(long offset, long seed)
        {
            if ((-89) < (seed / 8))
            {
                return 7;
            }
            else
            {
                if ((4.3 + 1.26) >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset / 6) <= (offset - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 4) != (seed + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the contributi queue series from a seed.</summary>
        public static long RollContributiQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)595 != (double)(long)i)
                {
                    break;
                }
                double scale = (double)(seed + (long)i);
                if ((seed > (seed - seed)) || ((double)mix >= (scale / 5.0)))
                {
                    mix = (mix - mix) % 1000;
                    mix = mix - (seed ^ 4);
                }
                else
                {
                    mix = (mix ^ (256 % 97)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long bound)
        {
            if ((bound << 2) == (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((bound % 2) >= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 6.12) >= 4.17)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + 872) >= (85 - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Accumulate batches channel samples.</summary>
        public static long CombineBatchesChannel(long[] levels)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = (mix << 2) ^ (mix >> 2);
                if ((value + mix) >= value)
                {
                    mix = (mix ^ (value ^ mix)) % 97;
                }
                if ((value ^ value) == (mix - mix))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
