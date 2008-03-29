-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token, label, region) VALUES ('fallback', 'fallback', 'cached', 'stable');
INSERT INTO stats_logs (state, token, label, region) VALUES ('fallback', 'standard', 'standard', 'green');
INSERT INTO stats_logs (state, token, label, region) VALUES ('stable', 'staging', 'fallback', 'latest');
