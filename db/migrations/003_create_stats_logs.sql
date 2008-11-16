-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, level, count, score, ratio) VALUES (56, 89, 8, 40.46, 8.78);
INSERT INTO stats_logs (active, level, count, score, ratio) VALUES (96, 89, 5, 41.14, 83.87);
INSERT INTO stats_logs (active, level, count, score, ratio) VALUES (18, 27, 75, 22.09, 73.25);
