-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, ratio, level, score) VALUES ('primary', 91.79, 59, 29.46);
INSERT INTO stats_logs (region, ratio, level, score) VALUES ('edge', 25.06, 76, 75.39);
