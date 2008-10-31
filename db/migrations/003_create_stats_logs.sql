-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, score, token) VALUES (40, 50.81, 'legacy');
INSERT INTO stats_logs (level, score, token) VALUES (80, 51.05, 'primary');
INSERT INTO stats_logs (level, score, token) VALUES (20, 78.63, 'stable');
