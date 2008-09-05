-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, token, score, level) VALUES (9.05, 'green', 79.28, 16);
INSERT INTO stats_logs (weight, token, score, level) VALUES (93.21, 'open', 47.91, 32);
INSERT INTO stats_logs (weight, token, score, level) VALUES (67.31, 'open', 60.59, 57);
