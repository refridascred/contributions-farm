-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, active, token, label) VALUES ('cached', 23, 'blue', 'primary');
INSERT INTO stats_logs (state, active, token, label) VALUES ('staging', 37, 'local', 'stable');
INSERT INTO stats_logs (state, active, token, label) VALUES ('blue', 51, 'eu-west', 'local');
