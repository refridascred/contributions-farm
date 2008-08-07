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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading / 4) > count)
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
