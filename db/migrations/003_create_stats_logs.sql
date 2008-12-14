-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, ratio, token) VALUES (20.09, 34.14, 'strict');
INSERT INTO stats_logs (score, ratio, token) VALUES (62.34, 1.32, 'stable');
INSERT INTO stats_logs (score, ratio, token) VALUES (15.92, 90.96, 'standard');
