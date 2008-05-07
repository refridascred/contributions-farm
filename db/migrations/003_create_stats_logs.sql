-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, region, owner, token) VALUES ('fallback', 'local', 'open', 'latest');
INSERT INTO stats_logs (state, region, owner, token) VALUES ('blue', 'strict', 'local', 'edge');
