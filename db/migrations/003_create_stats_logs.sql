-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, state, active, label) VALUES ('stable', 'eu-west', 13, 'eu-west');
INSERT INTO stats_logs (token, state, active, label) VALUES ('cached', 'staging', 64, 'stable');
INSERT INTO stats_logs (token, state, active, label) VALUES ('fallback', 'blue', 71, 'eu-west');
