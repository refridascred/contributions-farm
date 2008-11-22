-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, ratio, region, weight, state) VALUES (32, 63.92, 'eu-west', 22.53, 'eu-west');
INSERT INTO stats_logs (active, ratio, region, weight, state) VALUES (30, 44.85, 'green', 0.98, 'standard');
INSERT INTO stats_logs (active, ratio, region, weight, state) VALUES (95, 64.07, 'strict', 19.55, 'green');
