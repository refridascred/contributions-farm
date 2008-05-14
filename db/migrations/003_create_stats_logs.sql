-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, count, ratio, level, rank) VALUES (39, 19, 12.78, 2, 40);
INSERT INTO stats_logs (active, count, ratio, level, rank) VALUES (68, 6, 88.64, 58, 80);
