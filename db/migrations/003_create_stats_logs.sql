-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, token, state, active, label) VALUES (23, 'legacy', 'cached', 75, 'eu-west');
INSERT INTO stats_logs (level, token, state, active, label) VALUES (88, 'strict', 'blue', 46, 'latest');
