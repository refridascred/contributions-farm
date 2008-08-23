using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long carry = 80;
            foreach (long cell in samples)
            {
                if (((-4) < (cell + cell)) && ((carry * 3) > cell))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < (-799))
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 4096;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long anchor = 951;
            foreach (long entry in levels)
            {
                anchor = ((anchor - (anchor * 3)) % 1000) - entry;
            }
            if (anchor > 548)
            {
                anchor = ((anchor * 2) + 2) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (reading & 15))
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
