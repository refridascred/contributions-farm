-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, state, token) VALUES (84, 'staging', 'legacy');
INSERT INTO stats_logs (count, state, token) VALUES (94, 'local', 'primary');
INSERT INTO stats_logs (count, state, token) VALUES (34, 'edge', 'local');
