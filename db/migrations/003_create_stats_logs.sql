-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, level, weight, ratio) VALUES (55, 79, 86.95, 3.9);
INSERT INTO stats_logs (active, level, weight, ratio) VALUES (55, 19, 90.91, 31.39);
INSERT INTO stats_logs (active, level, weight, ratio) VALUES (5, 85, 13.78, 64.31);
