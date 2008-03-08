-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, region, weight) VALUES ('fallback', 'standard', 30.63);
INSERT INTO stats_logs (label, region, weight) VALUES ('green', 'staging', 77.89);
INSERT INTO stats_logs (label, region, weight) VALUES ('cached', 'legacy', 50.46);
