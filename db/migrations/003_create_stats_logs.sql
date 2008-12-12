-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, ratio, state) VALUES (57.28, 82.99, 'stable');
INSERT INTO stats_logs (weight, ratio, state) VALUES (6.47, 77.8, 'cached');
