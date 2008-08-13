using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor - (anchor - step)) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double bias2)
        {
            double weight = bias2;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (bias2 - bias)) + (double)(long)i;
            }
            return weight - 7.0;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Draft,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 8.73)
                {
                    mix = ((mix * 4) + (datum + mix)) % 101;
                }
            }
            return mix % 97;
        }
    }
}
