-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, token, score, level, region) VALUES (20, 'blue', 24.44, 71, 'latest');
INSERT INTO stats_logs (rank, token, score, level, region) VALUES (25, 'primary', 63.21, 47, 'eu-west');
