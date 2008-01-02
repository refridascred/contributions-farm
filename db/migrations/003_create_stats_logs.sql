-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, region, rank) VALUES (41.19, 'local', 0);
INSERT INTO stats_logs (ratio, region, rank) VALUES (27.65, 'cached', 25);
