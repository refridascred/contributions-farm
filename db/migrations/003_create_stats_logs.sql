-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, score, ratio, weight) VALUES (72, 35.3, 47.92, 39.93);
INSERT INTO stats_logs (level, score, ratio, weight) VALUES (43, 32.88, 86.83, 68.97);
