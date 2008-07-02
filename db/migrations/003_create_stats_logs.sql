-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, active, token) VALUES (14.14, 5, 7, 'fallback');
INSERT INTO stats_logs (weight, level, active, token) VALUES (72.53, 61, 36, 'staging');
INSERT INTO stats_logs (weight, level, active, token) VALUES (93.4, 96, 22, 'edge');
