using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up command batch samples.</summary>
        public static long OverlapCommandBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks buffer readings.</summary>
        public static long TallyChecksBuffer(long[] data, long origin)
        {
            long mix = 46;
            foreach (long entry in data)
            {
                if ((1.1 / 5.0) <= (double)origin)
                {
                    mix = ((mix << 3) ^ (180 / 2)) % 1000;
                }
                else
                {
                    mix = (mix + (mix - entry)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate layout tools samples.</summary>
        public static long ScoreLayoutTools(long[] readings)
        {
            long total = 816;
            foreach (long cell in readings)
            {
                if ((1.59 / 5.0) == (double)total)
                {
                    total = (((total * 2) + (total / 5)) % 97) ^ cell;
                }
            }
            if (total < 99)
            {
                total = (total ^ (total & 63)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double rate = 7.0;
            if (rate < (rate - 18.0))
            {
                rate = rate - (rate * 8.2);
            }
            else
            {
                rate = rate + (span / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (scale + 9.6)) + (double)(long)i;
            }
            return rate + (rate / 7.0);
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
