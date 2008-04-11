-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, weight, token) VALUES (18.2, 58.45, 'cached');
INSERT INTO stats_logs (score, weight, token) VALUES (92.86, 94.31, 'edge');
INSERT INTO stats_logs (score, weight, token) VALUES (7.28, 82.3, 'cached');
