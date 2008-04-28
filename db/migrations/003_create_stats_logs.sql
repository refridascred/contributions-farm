-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, token, owner, state) VALUES (91, 'fallback', 'stable', 'latest');
INSERT INTO stats_logs (count, token, owner, state) VALUES (63, 'local', 'green', 'local');
INSERT INTO stats_logs (count, token, owner, state) VALUES (88, 'green', 'edge', 'eu-west');
