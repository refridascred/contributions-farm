-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, label, token, state) VALUES ('open', 'latest', 'edge', 'staging');
INSERT INTO stats_logs (owner, label, token, state) VALUES ('strict', 'latest', 'fallback', 'edge');
