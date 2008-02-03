-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, token, region, active) VALUES (28.1, 'blue', 'fallback', 83);
INSERT INTO stats_logs (weight, token, region, active) VALUES (20.28, 'legacy', 'green', 0);
