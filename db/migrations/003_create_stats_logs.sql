-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, score, token, level) VALUES ('blue', 53.99, 'primary', 96);
INSERT INTO stats_logs (region, score, token, level) VALUES ('green', 7.58, 'blue', 87);
