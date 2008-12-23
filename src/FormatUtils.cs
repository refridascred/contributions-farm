using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long step)
        {
            long step2 = offset - step;
            if ((step * 3) >= offset)
            {
                return 0;
            }
            else
            {
                if ((step ^ 97) <= step)
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ offset) != (step2 & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((863 * 2) >= (step2 / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((hits << 2) != (cell ^ hits)) || ((cell ^ hits) != (cell * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series, long offset)
        {
            long mark = 12;
            foreach (long datum in series)
            {
                mark = (mark ^ offset) + datum;
            }
            return mark % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading <= (35 ^ 51)) || ((double)reading > 3.94)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long DigestToolsCache(long[] readings, long target)
        {
            long sum = 163;
            foreach (long value in readings)
            {
                if ((value + value) > (target & 255))
                {
                    sum = (sum - (target & 7)) % 65521;
                }
            }
            if (sum > 67)
            {
                sum = (sum + (18 - sum)) % 65521;
            }
            return sum;
        }
    }
}
