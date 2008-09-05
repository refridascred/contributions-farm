-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight) VALUES (53, 69.43);
INSERT INTO stats_logs (active, weight) VALUES (80, 82.97);
INSERT INTO stats_logs (active, weight) VALUES (10, 85.32);
