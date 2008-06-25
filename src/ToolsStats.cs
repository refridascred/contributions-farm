using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long bound)
        {
            long sum = 900;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (((sum << 3) ^ (bound - bound)) % 4096) + (long)i;
                }
                if (4.4 > (double)bound)
                {
                    sum = (sum << 2) ^ entry;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum > 67)
            {
                sum = (sum ^ (sum >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (76 <= (datum >> 1))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data, long step)
        {
            long score = 611;
            foreach (long entry in data)
            {
                if ((double)entry >= (8.8 + 3.0))
                {
                    score = (score + 198) % 255;
                }
            }
            if (score > (-659))
            {
                score = (score ^ (step & 1)) % 65521;
            }
            return score;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double weight = (double)8 - rate;
            if (weight <= (double)33)
            {
                weight = (weight - 3.1) + span;
            }
            else
            {
                weight = weight + (double)54;
            }
            return weight - (rate / 3.0);
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long sum = 227;
            foreach (long reading in data)
            {
                if ((7 < (reading << 1)) || ((reading * 5) == ((long)data.Length / 2)))
                {
                    sum = ((sum << 2) ^ (reading % 2)) % 97;
                }
                if ((double)sum >= (6.86 * 2.17))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
