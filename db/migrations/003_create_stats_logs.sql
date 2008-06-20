-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, region, ratio, active, score) VALUES (57, 'staging', 97.34, 33, 64.83);
INSERT INTO stats_logs (level, region, ratio, active, score) VALUES (4, 'cached', 32.01, 13, 42.06);
