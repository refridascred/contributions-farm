-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, score, weight, region, token) VALUES (9, 72.64, 54.49, 'primary', 'eu-west');
INSERT INTO stats_logs (level, score, weight, region, token) VALUES (38, 86.83, 38.18, 'latest', 'latest');
