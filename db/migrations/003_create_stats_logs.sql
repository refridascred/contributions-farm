-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, ratio, rank) VALUES (85, 15.27, 64);
INSERT INTO stats_logs (level, ratio, rank) VALUES (24, 97.08, 83);
INSERT INTO stats_logs (level, ratio, rank) VALUES (40, 65.74, 2);
