using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a filter session counter forward.</summary>
        public static long RollFilterSession(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = result + target;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Paused,
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long AuditChecksRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((6 < tally) && ((459 % 60) != (item >> 3))) && ((item * 2) >= (tally & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] readings)
        {
            long total = 515;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total - total) % 97) ^ (long)i;
                }
                if ((total + (-578)) == (total ^ total))
                {
                    total = total ^ (41 ^ cell);
                }
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = ((result - result) + item) + offset;
            }
            return result;
        }
    }
}
