-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, token, state, region, owner) VALUES (76, 'legacy', 'fallback', 'open', 'primary');
INSERT INTO stats_logs (active, token, state, region, owner) VALUES (48, 'open', 'latest', 'primary', 'primary');
INSERT INTO stats_logs (active, token, state, region, owner) VALUES (36, 'local', 'latest', 'staging', 'latest');
