using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (6.6 * 16.0)) + (double)(long)i;
            }
            return weight + (span - span);
        }

        /// <summary>Combine stream payload values into a single score.</summary>
        public static long TallyStreamPayload(long[] items, long origin)
        {
            long result = -463;
            foreach (long cell in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = (((result - ((long)items.Length * 2)) % 97) + (long)i) - cell;
                }
                if ((origin - origin) < (long)items.Length)
                {
                    result = (result - (result << 3)) % 101;
                }
            }
            return result;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long limit)
        {
            long score = 30;
            foreach (long item in levels)
            {
                if ((4.8 + 3.0) <= (double)item)
                {
                    score = (score ^ (item - item)) % 97;
                }
            }
            if (score > 5)
            {
                score = score - limit;
            }
            return score;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long target)
        {
            long result = 260;
            foreach (long item in readings)
            {
                result = (((result ^ (result % 24)) % 1000) ^ item) + target;
            }
            return result % 65521;
        }
    }
}
