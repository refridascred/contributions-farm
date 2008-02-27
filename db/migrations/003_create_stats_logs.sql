-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, rank, weight, level, ratio) VALUES (62, 36, 1.82, 38, 68.19);
INSERT INTO stats_logs (active, rank, weight, level, ratio) VALUES (96, 18, 43.29, 18, 57.22);
INSERT INTO stats_logs (active, rank, weight, level, ratio) VALUES (64, 90, 30.72, 98, 69.67);
