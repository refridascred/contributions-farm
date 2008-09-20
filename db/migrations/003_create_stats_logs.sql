-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, score, region, token) VALUES (89.13, 96.84, 'cached', 'latest');
INSERT INTO stats_logs (weight, score, region, token) VALUES (13.07, 5.18, 'latest', 'fallback');
