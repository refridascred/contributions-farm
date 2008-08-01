-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, label, region, rank) VALUES (32.85, 'fallback', 'blue', 53);
INSERT INTO stats_logs (weight, label, region, rank) VALUES (20.98, 'edge', 'legacy', 61);
