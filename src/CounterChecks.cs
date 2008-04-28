using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double mean = rate - (rate + offset);
            if (mean > (rate / 5.0))
            {
                mean = mean + (double)661;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - rate)) - (double)(long)i;
            }
            return mean + (double)17;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long step)
        {
            long bound = target + step;
            if (!(bound <= 293))
            {
                return 8;
            }
            else
            {
                if ((9 % 100) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((step / 5) == (bound % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step > (step & 7)) && ((double)bound == (13.0 * 10.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((hits >> 5) < offset) && ((0 / 5) > (sample * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length != (64 ^ target))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long sum = 66;
            foreach (long cell in levels)
            {
                if ((cell / 6) <= (sum * 3))
                {
                    sum = (sum + (cell ^ cell)) % 1000;
                }
                if (((cell + cell) >= (sum + sum)) || (62 < (cell & 15)))
                {
                    sum = (sum << 2) ^ (cell + sum);
                }
                if ((7.9 - 9.53) != (double)cell)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
