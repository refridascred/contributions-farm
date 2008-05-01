-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, score, token, weight, count) VALUES ('green', 41.73, 'cached', 16.44, 44);
INSERT INTO stats_logs (region, score, token, weight, count) VALUES ('local', 45.23, 'legacy', 34.94, 67);
