-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, token, state, region) VALUES ('fallback', 'strict', 'legacy', 'staging');
INSERT INTO stats_logs (owner, token, state, region) VALUES ('fallback', 'green', 'cached', 'cached');
INSERT INTO stats_logs (owner, token, state, region) VALUES ('open', 'stable', 'blue', 'fallback');
