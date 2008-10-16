using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every graph command entry stays within the limit.</summary>
        public static bool ValidateGraphCommandBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double offset)
        {
            double drift = (double)2 * 4.82;
            if (drift < (gain * 8.1))
            {
                drift = drift - (gain * 6.0);
            }
            return drift + offset;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum ^ datum) >= (seen & 63)) && (((target << 3) == (long)samples.Length) && ((datum * 2) == (7 / 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long origin)
        {
            if ((double)target > (7.52 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((target / 9) >= (7 - target))
                {
                    return 6;
                }
                else
                {
                    if (!((origin % 97) != (target - 25)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target ^ target) == (463 - origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
