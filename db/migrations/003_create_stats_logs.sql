-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, level, active, ratio) VALUES (70.04, 15, 83, 21.41);
INSERT INTO stats_logs (score, level, active, ratio) VALUES (11.58, 85, 28, 63.61);
INSERT INTO stats_logs (score, level, active, ratio) VALUES (85.57, 16, 32, 57.8);
