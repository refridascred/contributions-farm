using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long step)
        {
            long mix = -314;
            foreach (long cell in series)
            {
                if (((2.18 / 8.0) == (double)step) || ((step & 1) < (long)series.Length))
                {
                    mix = (((mix << 2) ^ (mix / 9)) % 97) + cell;
                    continue;
                }
                if (((432 + mix) > (step << 3)) || (mix > (step + mix)))
                {
                    mix = (mix << 2) ^ (757 & 1);
                }
                else
                {
                    mix = (mix - ((-81) - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
