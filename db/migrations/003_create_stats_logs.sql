-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, state) VALUES (98.85, 'local');
INSERT INTO stats_logs (weight, state) VALUES (20.31, 'stable');
INSERT INTO stats_logs (weight, state) VALUES (45.04, 'blue');
