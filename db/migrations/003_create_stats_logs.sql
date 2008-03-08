-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, token, region) VALUES ('edge', 'standard', 'blue');
INSERT INTO stats_logs (state, token, region) VALUES ('cached', 'legacy', 'strict');
