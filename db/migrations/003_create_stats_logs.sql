-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, active, weight) VALUES ('strict', 64, 60.0);
INSERT INTO stats_logs (region, active, weight) VALUES ('stable', 3, 89.5);
INSERT INTO stats_logs (region, active, weight) VALUES ('cached', 86, 71.85);
