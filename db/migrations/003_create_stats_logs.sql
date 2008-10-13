-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, owner, region, state) VALUES ('stable', 'latest', 'legacy', 'local');
INSERT INTO stats_logs (token, owner, region, state) VALUES ('open', 'fallback', 'green', 'blue');
