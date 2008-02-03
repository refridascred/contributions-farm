-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, level, score, ratio) VALUES ('strict', 54, 49.55, 64.38);
INSERT INTO stats_logs (token, level, score, ratio) VALUES ('open', 89, 20.64, 8.7);
INSERT INTO stats_logs (token, level, score, ratio) VALUES ('local', 49, 6.72, 32.78);
