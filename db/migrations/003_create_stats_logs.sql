-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, level, rank) VALUES (64.86, 11, 56);
INSERT INTO stats_logs (ratio, level, rank) VALUES (33.84, 19, 25);
INSERT INTO stats_logs (ratio, level, rank) VALUES (65.15, 56, 98);
