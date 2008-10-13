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

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double offset)
        {
            double bias = ratio;
            return (bias - (ratio + 5.0)) + offset;
        }

        /// <summary>Combine batches format values into a single score.</summary>
        public static long FoldBatchesFormat(long[] values, long limit)
        {
            long mark = 2;
            foreach (long datum in values)
            {
                if ((mark + mark) < mark)
                {
                    mark = ((mark - (datum + datum)) % 65521) + limit;
                }
            }
            if (mark > 9)
            {
                mark = (mark ^ (mark - 583)) % 101;
            }
            return mark % 1000;
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
