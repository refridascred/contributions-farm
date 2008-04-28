-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, state, token, label) VALUES (84, 'cached', 'eu-west', 'edge');
INSERT INTO stats_logs (count, state, token, label) VALUES (46, 'fallback', 'latest', 'legacy');
INSERT INTO stats_logs (count, state, token, label) VALUES (93, 'strict', 'local', 'latest');
