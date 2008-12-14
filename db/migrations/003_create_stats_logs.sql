-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, count, score, active, level) VALUES (9.27, 70, 40.5, 56, 27);
INSERT INTO stats_logs (ratio, count, score, active, level) VALUES (43.44, 68, 81.36, 84, 43);
INSERT INTO stats_logs (ratio, count, score, active, level) VALUES (65.42, 33, 81.58, 31, 84);
