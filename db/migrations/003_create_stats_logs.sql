-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, weight, owner) VALUES ('legacy', 18.48, 'fallback');
INSERT INTO stats_logs (region, weight, owner) VALUES ('primary', 50.63, 'eu-west');
INSERT INTO stats_logs (region, weight, owner) VALUES ('blue', 3.25, 'edge');
