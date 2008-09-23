-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, active, level, weight, rank) VALUES (58.57, 77, 71, 50.86, 82);
INSERT INTO stats_logs (ratio, active, level, weight, rank) VALUES (31.35, 97, 48, 21.93, 94);
