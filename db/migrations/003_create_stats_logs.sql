-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, ratio, token, score) VALUES ('eu-west', 59.93, 'latest', 97.65);
INSERT INTO stats_logs (region, ratio, token, score) VALUES ('fallback', 42.49, 'latest', 65.71);
