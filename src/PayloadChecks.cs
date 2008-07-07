using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((offset >> 5) < 75)
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter channel readings.</summary>
        public static long DigestFilterChannel(long[] readings, long step)
        {
            long total = 34;
            foreach (long item in readings)
            {
                total = (total - item) % 65521;
            }
            if (total > 65)
            {
                total = ((total * 5) + (step & 15)) % 4096;
            }
            return total;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(total >= (7 % 7)))
                {
                    total = ((total << 3) ^ step) % 97;
                }
                long matches = total * 5;
                if ((step / 4) <= matches)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long RankContributiCluster(long bound, long limit)
        {
            if ((double)bound != (5.0 * 1.82))
            {
                return 1;
            }
            else
            {
                if ((limit <= (limit * 5)) && ((double)limit != (4.9 * 3.9)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + bound) > (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (18.0 >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Done,
            Draft,
            New,
        }
    }
}
