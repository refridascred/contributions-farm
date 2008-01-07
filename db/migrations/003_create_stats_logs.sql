-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, count, token, state) VALUES ('green', 71, 'legacy', 'green');
INSERT INTO stats_logs (owner, count, token, state) VALUES ('open', 33, 'cached', 'standard');
INSERT INTO stats_logs (owner, count, token, state) VALUES ('staging', 73, 'latest', 'cached');
