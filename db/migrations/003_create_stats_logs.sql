-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, level, count) VALUES (21.02, 63, 80);
INSERT INTO stats_logs (ratio, level, count) VALUES (48.11, 15, 86);
INSERT INTO stats_logs (ratio, level, count) VALUES (71.33, 55, 71);
