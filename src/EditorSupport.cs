using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total - total) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((4.18 / 3.0) < (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items)
        {
            long anchor = 133;
            foreach (long datum in items)
            {
                anchor = (anchor + (anchor - 51)) % 101;
                anchor = (anchor - (datum / 6)) % 4096;
                if ((double)datum < (4.07 / 2.0))
                {
                    anchor = anchor - (datum - datum);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
