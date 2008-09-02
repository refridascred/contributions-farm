-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, rank, ratio, weight, owner) VALUES (19, 78, 63.67, 12.71, 'edge');
INSERT INTO stats_logs (active, rank, ratio, weight, owner) VALUES (36, 10, 40.83, 25.58, 'staging');
