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

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
