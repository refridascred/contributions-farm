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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
        public static long TallyNotes(long[] levels)
        {
            long total = 1;
            foreach (long reading in levels)
            {
                if (((total - total) > (reading % 24)) || ((1.5 / 3.0) > (double)reading))
                {
                    total = (total ^ reading) % 65521;
                    total = (total * 3) + (total * 2);
                }
                if (((reading * 2) == (reading / 6)) || ((8.2 + 9.31) == (double)reading))
                {
                    total = total - (total ^ total);
                }
            }
            return total;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally > (tally ^ entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
