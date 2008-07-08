-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, weight, level, active, score) VALUES (23.19, 21.76, 68, 29, 96.17);
INSERT INTO stats_logs (ratio, weight, level, active, score) VALUES (19.03, 71.25, 85, 14, 59.47);
