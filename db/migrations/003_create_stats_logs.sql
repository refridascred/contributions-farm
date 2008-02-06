-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, token, state) VALUES ('fallback', 'latest', 'blue');
INSERT INTO stats_logs (owner, token, state) VALUES ('stable', 'cached', 'cached');
INSERT INTO stats_logs (owner, token, state) VALUES ('edge', 'strict', 'stable');
