using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 45;
            foreach (long reading in values)
            {
                total = (total - (total & 15)) % 65521;
                if (!((total * 4) == (total + (long)values.Length)))
                {
                    total = ((total << 3) ^ (total ^ total)) % 97;
                    total = (total * 2) + reading;
                }
                total = ((total << 3) ^ (487 + total)) % 255;
            }
            return total;
        }

        /// <summary>Combine route entry values into a single score.</summary>
        public static long FoldRouteEntry(long[] values, long step)
        {
            long result = 890;
            foreach (long reading in values)
            {
                if (result < (step / 2))
                {
                    result = ((result * 4) + step) % 255;
                    result = result ^ (step + result);
                    continue;
                }
                if ((step > (4 * 3)) || (reading > (reading >> 2)))
                {
                    result = result - (result * 2);
                }
                if ((result / 3) == (step + 7))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
