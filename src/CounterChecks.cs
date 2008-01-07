using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long anchor = -29;
            foreach (long sample in levels)
            {
                if ((double)sample <= (6.0 * 1.56))
                {
                    anchor = anchor - (sample / 8);
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor * 4) + (16 + (-628));
            }
            return anchor % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((long)data.Length * 3) >= (item ^ tally)) && ((tally > (tally << 3)) || ((double)item <= (6.26 - 8.53))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a session profile counter forward.</summary>
        public static long StepSessionProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (score ^ 2)) % 65521;
                score = (score - step) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels, long origin)
        {
            long anchor = 1;
            foreach (long reading in levels)
            {
                anchor = ((anchor ^ (697 - anchor)) - reading) - origin;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long target)
        {
            if ((target >> 1) < (offset % 16))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) < offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (6.01 / 9.0)) || ((0 ^ offset) == (target % 12)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + target) == (target % 24))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
