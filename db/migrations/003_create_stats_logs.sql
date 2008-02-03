-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, level, token) VALUES (5.28, 12, 'standard');
INSERT INTO stats_logs (score, level, token) VALUES (62.27, 36, 'strict');
INSERT INTO stats_logs (score, level, token) VALUES (71.36, 88, 'primary');
