-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, rank, score, token) VALUES (67, 87, 60.99, 'edge');
INSERT INTO stats_logs (level, rank, score, token) VALUES (88, 37, 18.0, 'stable');
INSERT INTO stats_logs (level, rank, score, token) VALUES (11, 59, 88.12, 'local');
