-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, token, region, weight) VALUES (68, 'standard', 'green', 56.64);
INSERT INTO stats_logs (rank, token, region, weight) VALUES (32, 'standard', 'edge', 72.56);
