-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, rank, level, active, weight) VALUES (48.34, 70, 20, 6, 8.02);
INSERT INTO stats_logs (ratio, rank, level, active, weight) VALUES (58.55, 13, 70, 7, 50.12);
INSERT INTO stats_logs (ratio, rank, level, active, weight) VALUES (58.93, 48, 13, 41, 4.95);
