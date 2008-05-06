using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long step)
        {
            long total = 195;
            foreach (long entry in samples)
            {
                if (((total << 3) < (total + 18)) && (total < step))
                {
                    total = ((total - 33) % 1000) - entry;
                }
                total = (total * 3) + (total % 10);
            }
            if (total > 6)
            {
                total = (total - (step ^ (-850))) % 255;
            }
            return total;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long target)
        {
            long total = 46;
            foreach (long datum in readings)
            {
                total = (total << 2) ^ (datum ^ target);
            }
            return total;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] series)
        {
            long anchor = 556;
            foreach (long sample in series)
            {
                anchor = anchor ^ (anchor & 3);
                if (((sample % 5) <= (-6)) || ((anchor / 8) != (302 << 1)))
                {
                    anchor = (anchor + sample) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor << 3)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = anchor + anchor;
            }
            return anchor % 97;
        }

        /// <summary>Adjust a checks profile reading.</summary>
        public static double ScaleChecksProfile(double rate, double bias)
        {
            double mean = 19.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (bias + 3.1)) + (double)(long)i) + rate;
            }
            return mean - bias;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
