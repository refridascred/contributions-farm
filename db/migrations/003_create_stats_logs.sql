-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, level, score) VALUES (11.67, 80, 9.46);
INSERT INTO stats_logs (ratio, level, score) VALUES (59.61, 41, 84.74);
INSERT INTO stats_logs (ratio, level, score) VALUES (89.55, 14, 93.98);
