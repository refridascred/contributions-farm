-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, level, region, ratio) VALUES (34, 16, 'eu-west', 88.52);
INSERT INTO stats_logs (rank, level, region, ratio) VALUES (39, 77, 'strict', 45.39);
