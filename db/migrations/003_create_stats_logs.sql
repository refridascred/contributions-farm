-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, weight, token, rank, region) VALUES (69, 75.11, 'cached', 87, 'latest');
INSERT INTO stats_logs (count, weight, token, rank, region) VALUES (61, 50.53, 'standard', 88, 'standard');
