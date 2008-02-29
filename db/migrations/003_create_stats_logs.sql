-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, state) VALUES (81.51, 19.05, 'eu-west');
INSERT INTO stats_logs (ratio, weight, state) VALUES (30.23, 48.7, 'strict');
