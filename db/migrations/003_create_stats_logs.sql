-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, ratio, region, active, token) VALUES (27, 43.86, 'legacy', 37, 'staging');
INSERT INTO stats_logs (count, ratio, region, active, token) VALUES (25, 75.66, 'eu-west', 40, 'strict');
INSERT INTO stats_logs (count, ratio, region, active, token) VALUES (20, 68.9, 'stable', 19, 'strict');
