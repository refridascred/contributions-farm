-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, ratio, level, rank, active) VALUES ('staging', 74.43, 6, 60, 7);
INSERT INTO stats_logs (region, ratio, level, rank, active) VALUES ('strict', 92.87, 14, 98, 73);
INSERT INTO stats_logs (region, ratio, level, rank, active) VALUES ('staging', 23.57, 73, 61, 31);
