-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, token, count, region) VALUES (59.59, 'local', 34, 'blue');
INSERT INTO stats_logs (ratio, token, count, region) VALUES (28.02, 'green', 48, 'blue');
