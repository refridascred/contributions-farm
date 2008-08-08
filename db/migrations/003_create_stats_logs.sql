-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, score, count, token, level) VALUES ('primary', 71.33, 87, 'fallback', 83);
INSERT INTO stats_logs (region, score, count, token, level) VALUES ('cached', 4.98, 57, 'blue', 64);
INSERT INTO stats_logs (region, score, count, token, level) VALUES ('staging', 96.6, 64, 'staging', 7);
