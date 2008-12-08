using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long limit)
        {
            long gap = bound + limit;
            if ((bound <= gap) && (limit >= (bound << 1)))
            {
                return 2;
            }
            else
            {
                if (((bound - gap) < limit) && ((59 + 895) != (limit + limit)))
                {
                    return 0;
                }
                else
                {
                    if ((bound - bound) <= gap)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of session account readings.</summary>
        public static long ScoreSessionAccount(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if ((total & 127) > reading)
                {
                    total = ((total << 2) ^ (640 % 97)) % 65521;
                    continue;
                }
                if ((total % 7) <= (total + reading))
                {
                    total = total + (reading + reading);
                }
            }
            return total;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                mix = mix + (value * 5);
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultFactor = 4724;
        public const long BaseEditor = 7877;
        public const long DefaultEditor = 6130;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
