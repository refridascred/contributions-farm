-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, region, score, level, token) VALUES (64, 'staging', 60.49, 25, 'latest');
INSERT INTO stats_logs (count, region, score, level, token) VALUES (2, 'cached', 3.97, 68, 'open');
