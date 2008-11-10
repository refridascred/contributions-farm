-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, owner, label, token) VALUES ('strict', 'staging', 'eu-west', 'stable');
INSERT INTO stats_logs (state, owner, label, token) VALUES ('stable', 'legacy', 'stable', 'eu-west');
INSERT INTO stats_logs (state, owner, label, token) VALUES ('blue', 'primary', 'blue', 'legacy');
