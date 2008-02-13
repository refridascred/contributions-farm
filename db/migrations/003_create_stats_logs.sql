-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, state) VALUES (28.06, 'strict');
INSERT INTO stats_logs (weight, state) VALUES (51.44, 'green');
