-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, token, state) VALUES ('legacy', 'standard', 'local');
INSERT INTO stats_logs (owner, token, state) VALUES ('open', 'fallback', 'blue');
INSERT INTO stats_logs (owner, token, state) VALUES ('edge', 'local', 'strict');
