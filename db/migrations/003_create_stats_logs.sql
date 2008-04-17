-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, ratio, level, score) VALUES (23, 51.19, 90, 14.87);
INSERT INTO stats_logs (active, ratio, level, score) VALUES (60, 9.53, 19, 68.45);
INSERT INTO stats_logs (active, ratio, level, score) VALUES (20, 62.07, 5, 53.96);
