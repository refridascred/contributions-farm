-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, ratio, score, token) VALUES (55, 14.23, 98.86, 'latest');
INSERT INTO stats_logs (rank, ratio, score, token) VALUES (56, 72.45, 89.01, 'primary');
