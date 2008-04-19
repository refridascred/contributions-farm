-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, region, weight) VALUES (79, 'legacy', 20.74);
INSERT INTO stats_logs (rank, region, weight) VALUES (13, 'latest', 56.41);
INSERT INTO stats_logs (rank, region, weight) VALUES (96, 'cached', 63.54);
