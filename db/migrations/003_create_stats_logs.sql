-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, level, count, weight) VALUES (25.93, 39, 68, 92.6);
INSERT INTO stats_logs (ratio, level, count, weight) VALUES (16.66, 64, 72, 4.56);
INSERT INTO stats_logs (ratio, level, count, weight) VALUES (11.41, 52, 70, 44.72);
