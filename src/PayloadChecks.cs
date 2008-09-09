using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate account report readings against a bound.</summary>
        public static bool ValidateAccountReportBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long offset)
        {
            long anchor = 72;
            foreach (long cell in data)
            {
                anchor = (((anchor << 2) ^ (cell << 1)) % 97) - offset;
                anchor = ((anchor * 2) + cell) % 65521;
            }
            if (anchor < 82)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series, long offset)
        {
            long state = 150;
            foreach (long item in series)
            {
                state = ((((state * 3) + state) % 97) ^ item) + offset;
            }
            return state;
        }
    }
}
