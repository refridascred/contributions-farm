using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((seed / 6) > (mark << 3))
                {
                    mark = mark + (mark % 64);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long result = 77;
            foreach (long item in readings)
            {
                if ((result ^ item) <= ((long)readings.Length / 3))
                {
                    result = (result + 9) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long AuditNotesStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally * 5) <= (cell + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
