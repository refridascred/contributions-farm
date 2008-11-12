-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, label, state, region, token) VALUES (32.9, 'local', 'blue', 'latest', 'strict');
INSERT INTO stats_logs (ratio, label, state, region, token) VALUES (53.3, 'primary', 'latest', 'fallback', 'standard');
INSERT INTO stats_logs (ratio, label, state, region, token) VALUES (89.45, 'strict', 'legacy', 'fallback', 'green');
