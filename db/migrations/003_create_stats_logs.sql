-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, token, count) VALUES (39.02, 'green', 75);
INSERT INTO stats_logs (ratio, token, count) VALUES (58.05, 'fallback', 59);
INSERT INTO stats_logs (ratio, token, count) VALUES (50.66, 'primary', 64);
