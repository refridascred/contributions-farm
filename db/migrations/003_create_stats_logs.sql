-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token, active) VALUES ('open', 'local', 58);
INSERT INTO stats_logs (state, token, active) VALUES ('fallback', 'legacy', 30);
INSERT INTO stats_logs (state, token, active) VALUES ('local', 'fallback', 70);
