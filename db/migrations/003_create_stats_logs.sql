-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, token, weight, level, score) VALUES (31, 'blue', 97.02, 21, 30.1);
INSERT INTO stats_logs (active, token, weight, level, score) VALUES (30, 'open', 37.73, 29, 94.77);
INSERT INTO stats_logs (active, token, weight, level, score) VALUES (55, 'legacy', 92.23, 40, 35.38);
