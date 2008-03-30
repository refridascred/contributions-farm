-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, state, region, token) VALUES ('legacy', 'fallback', 'primary', 'strict');
INSERT INTO stats_logs (label, state, region, token) VALUES ('blue', 'staging', 'latest', 'legacy');
