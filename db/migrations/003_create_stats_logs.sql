-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, rank, ratio) VALUES ('fallback', 13, 11.66);
INSERT INTO stats_logs (region, rank, ratio) VALUES ('fallback', 61, 49.54);
INSERT INTO stats_logs (region, rank, ratio) VALUES ('legacy', 95, 24.52);
