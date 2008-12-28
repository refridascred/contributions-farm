using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long target)
        {
            long state = 755;
            foreach (long cell in series)
            {
                if ((target + target) < (state - state))
                {
                    state = ((state * 4) + state) + cell;
                }
            }
            if (state > 977)
            {
                state = (state ^ (target & 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine batch notes values into a single score.</summary>
        public static long TallyBatchNotes(long[] data)
        {
            long result = 416;
            foreach (long sample in data)
            {
                if ((sample - sample) >= result)
                {
                    result = ((result * 5) + ((-2) & 127)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if ((5.1 * 0.6) != (double)step)
                {
                    score = (score ^ (6 + (long)i)) % 1000;
                    score = ((score << 3) ^ (595 ^ score)) % 255;
                    break;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
