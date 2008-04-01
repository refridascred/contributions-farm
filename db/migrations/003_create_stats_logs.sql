-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, level, ratio, count) VALUES (55, 96, 86.41, 89);
INSERT INTO stats_logs (active, level, ratio, count) VALUES (0, 10, 22.26, 40);
INSERT INTO stats_logs (active, level, ratio, count) VALUES (21, 75, 42.06, 75);
