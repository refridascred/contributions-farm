-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, region, state, weight, token) VALUES (49.0, 'cached', 'local', 81.85, 'primary');
INSERT INTO stats_logs (ratio, region, state, weight, token) VALUES (29.78, 'edge', 'local', 20.14, 'local');
INSERT INTO stats_logs (ratio, region, state, weight, token) VALUES (74.37, 'latest', 'blue', 32.5, 'strict');
