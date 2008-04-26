-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, active, label) VALUES (34.7, 27, 'stable');
INSERT INTO stats_logs (weight, active, label) VALUES (26.74, 21, 'legacy');
INSERT INTO stats_logs (weight, active, label) VALUES (76.44, 43, 'edge');
