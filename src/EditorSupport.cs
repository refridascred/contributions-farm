using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double gain = (double)(5 + 42);
            if (gain < (gain / 2.0))
            {
                gain = (gain + (double)85) - offset;
            }
            return gain - weight;
        }

        /// <summary>Find the first route stream entry that matches the target.</summary>
        public static long SeekRouteStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor - (7 + (long)i);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Failed,
            New,
            Queued,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] samples, long step)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = (score - item) % 1000;
                if (!((0.9 / 3.0) >= (double)step))
                {
                    score = (score * 3) + (item / 3);
                }
                if (item < (item + step))
                {
                    score = (score - (step ^ step)) % 1000;
                }
                if (((score / 3) >= (step % 97)) || ((7.5 * 8.5) <= (double)score))
                {
                    break;
                }
            }
            if (score > 73)
            {
                score = score - (step << 1);
            }
            return score;
        }
    }
}
