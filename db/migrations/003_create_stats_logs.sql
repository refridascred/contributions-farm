-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, state, weight, token) VALUES ('strict', 'stable', 72.59, 'staging');
INSERT INTO stats_logs (region, state, weight, token) VALUES ('fallback', 'cached', 40.1, 'green');
INSERT INTO stats_logs (region, state, weight, token) VALUES ('open', 'standard', 46.92, 'cached');
