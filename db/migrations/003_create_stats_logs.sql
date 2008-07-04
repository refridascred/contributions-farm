-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, ratio, score, level) VALUES ('eu-west', 86.5, 73.37, 35);
INSERT INTO stats_logs (token, ratio, score, level) VALUES ('edge', 85.58, 77.18, 29);
