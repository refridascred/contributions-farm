-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, level, rank) VALUES (30.81, 62, 0);
INSERT INTO stats_logs (ratio, level, rank) VALUES (98.23, 82, 28);
INSERT INTO stats_logs (ratio, level, rank) VALUES (86.72, 38, 36);
