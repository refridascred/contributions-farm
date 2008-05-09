-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, region, weight) VALUES (24, 'latest', 4.61);
INSERT INTO stats_logs (rank, region, weight) VALUES (62, 'staging', 17.92);
