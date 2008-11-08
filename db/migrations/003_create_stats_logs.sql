-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, count, region, rank) VALUES ('green', 68, 'stable', 55);
INSERT INTO stats_logs (owner, count, region, rank) VALUES ('primary', 37, 'cached', 83);
INSERT INTO stats_logs (owner, count, region, rank) VALUES ('primary', 23, 'edge', 67);
