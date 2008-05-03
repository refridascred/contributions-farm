-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token) VALUES ('legacy', 'local');
INSERT INTO stats_logs (state, token) VALUES ('blue', 'standard');
INSERT INTO stats_logs (state, token) VALUES ('blue', 'fallback');
