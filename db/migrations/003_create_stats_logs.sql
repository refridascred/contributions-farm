-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, token, region, rank) VALUES (89.38, 'strict', 'latest', 70);
INSERT INTO stats_logs (ratio, token, region, rank) VALUES (8.21, 'edge', 'cached', 25);
