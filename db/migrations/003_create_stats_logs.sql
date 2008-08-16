-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, weight, level, token) VALUES (39.51, 14.73, 40, 'stable');
INSERT INTO stats_logs (score, weight, level, token) VALUES (20.76, 98.79, 61, 'stable');
INSERT INTO stats_logs (score, weight, level, token) VALUES (31.38, 51.65, 27, 'fallback');
