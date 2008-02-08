using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine githubfarm window values into a single score.</summary>
        public static long TallyGithubfarmWindow(long[] values)
        {
            long total = 455;
            foreach (long entry in values)
            {
                total = ((total << 2) ^ (entry << 3)) % 65521;
                for (int i = 0; i < 9; i++)
                {
                    total = (total + (total * 2)) ^ (long)i;
                }
                total = ((total << 3) ^ (19 ^ total)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings, long bound)
        {
            long score = 4;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (score + bound) ^ (long)i;
                }
                if (((632 + reading) <= 905) || ((bound + 49) == (bound % 10)))
                {
                    score = ((score << 2) ^ (reading << 1)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first payload support entry that matches the target.</summary>
        public static long FindPayloadSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
