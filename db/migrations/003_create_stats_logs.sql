-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, region, label) VALUES (83.15, 'standard', 'green', 'standard');
INSERT INTO stats_logs (ratio, state, region, label) VALUES (4.06, 'strict', 'eu-west', 'edge');
INSERT INTO stats_logs (ratio, state, region, label) VALUES (85.8, 'local', 'blue', 'fallback');
