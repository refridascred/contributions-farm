using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data)
        {
            long anchor = 95;
            foreach (long item in data)
            {
                if ((3.0 * 8.0) != (double)item)
                {
                    anchor = (anchor - ((-954) % 7)) % 1000;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi token figure with a bias.</summary>
        public static double ScaleContributiToken(double gain, double offset)
        {
            double weight = gain / 5.0;
            if (weight < (gain * 11.0))
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (weight - gain);
        }

        /// <summary>Rank support layout input into a small class.</summary>
        public static long BucketSupportLayout(long bound, long bound2)
        {
            if (bound > (bound - 0))
            {
                return 3;
            }
            else
            {
                if ((bound - bound2) > (bound % 2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Queued,
            Done,
        }
    }
}
