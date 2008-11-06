-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, state, owner) VALUES ('fallback', 'staging', 'eu-west');
INSERT INTO stats_logs (token, state, owner) VALUES ('green', 'legacy', 'blue');
INSERT INTO stats_logs (token, state, owner) VALUES ('stable', 'green', 'latest');
