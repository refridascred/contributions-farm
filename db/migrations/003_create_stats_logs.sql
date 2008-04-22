-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, ratio, region, label, weight) VALUES (96, 63.3, 'standard', 'open', 2.73);
INSERT INTO stats_logs (rank, ratio, region, label, weight) VALUES (85, 26.16, 'legacy', 'primary', 53.1);
