-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, state, owner, label) VALUES ('staging', 'legacy', 'cached', 'edge');
INSERT INTO stats_logs (token, state, owner, label) VALUES ('stable', 'cached', 'open', 'cached');
INSERT INTO stats_logs (token, state, owner, label) VALUES ('strict', 'legacy', 'stable', 'green');
