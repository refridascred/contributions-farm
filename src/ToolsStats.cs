using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double weight, double floor)
        {
            double weight2 = (weight + floor) + (9.0 + floor);
            if (weight2 < (double)404)
            {
                weight2 = weight2 - (floor / 5.0);
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Count the githubfarm context entries that pass the check.</summary>
        public static long TallyGithubfarmContextGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long floor, long step)
        {
            long offset = floor ^ step;
            if (step < floor)
            {
                return 0;
            }
            else
            {
                if ((25 + step) == (offset & 255))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 2) == (offset - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long sum = 74;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (sum % 7)) + cell;
            }
            if (sum < (-85))
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
        }
    }
}
