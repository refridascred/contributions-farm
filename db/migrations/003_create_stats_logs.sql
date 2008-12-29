-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, level, rank) VALUES ('edge', 8, 37);
INSERT INTO stats_logs (region, level, rank) VALUES ('local', 60, 30);
