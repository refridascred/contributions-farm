-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, level, label, owner) VALUES (92, 82.71, 11, 'standard', 'blue');
INSERT INTO stats_logs (active, weight, level, label, owner) VALUES (90, 20.59, 49, 'standard', 'staging');
INSERT INTO stats_logs (active, weight, level, label, owner) VALUES (86, 92.14, 55, 'open', 'blue');
