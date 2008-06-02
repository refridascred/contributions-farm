-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, weight, level) VALUES ('fallback', 96.26, 6);
INSERT INTO stats_logs (region, weight, level) VALUES ('strict', 48.81, 90);
