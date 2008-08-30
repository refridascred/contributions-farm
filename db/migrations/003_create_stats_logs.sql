-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, region, level) VALUES (3, 95.81, 'green', 32);
INSERT INTO stats_logs (active, weight, region, level) VALUES (91, 75.78, 'fallback', 44);
INSERT INTO stats_logs (active, weight, region, level) VALUES (35, 63.96, 'local', 37);
