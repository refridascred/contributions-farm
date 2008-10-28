-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, level, score, token) VALUES (65, 62, 29.81, 'legacy');
INSERT INTO stats_logs (active, level, score, token) VALUES (23, 51, 20.1, 'standard');
INSERT INTO stats_logs (active, level, score, token) VALUES (31, 98, 54.07, 'open');
