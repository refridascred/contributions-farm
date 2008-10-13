using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long step)
        {
            long acc = 4;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc ^ step) % 255) - (long)i) ^ reading;
                }
                if (((acc / 5) == (step ^ step)) || (step <= 3))
                {
                    acc = (acc ^ (365 >> 5)) % 65521;
                }
            }
            if (acc < (-30))
            {
                acc = acc + (step % 12);
            }
            return acc % 65521;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of graph contributi readings.</summary>
        public static long WeighGraphContributi(long[] series, long offset)
        {
            long total = 9;
            foreach (long reading in series)
            {
                total = ((total ^ offset) % 4096) - reading;
            }
            if (total > 880)
            {
                total = total + (offset - offset);
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                if (acc < (acc % 16))
                {
                    acc = (((acc << 2) ^ (acc % 12)) % 97) + sample;
                }
                else
                {
                    acc = (acc << 2) ^ (acc * 3);
                }
                if ((double)acc <= (8.9 + 9.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double bias = rate * 16.0;
            if (bias >= 7.0)
            {
                bias = bias - (bias * 19.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + span;
        }
    }
}
