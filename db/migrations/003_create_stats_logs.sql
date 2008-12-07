-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, state, active, label) VALUES ('cached', 'fallback', 8, 'cached');
INSERT INTO stats_logs (token, state, active, label) VALUES ('local', 'standard', 64, 'blue');
INSERT INTO stats_logs (token, state, active, label) VALUES ('standard', 'legacy', 1, 'local');
