-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, state, count, label, token) VALUES (33, 'strict', 98, 'stable', 'stable');
INSERT INTO stats_logs (active, state, count, label, token) VALUES (90, 'open', 51, 'fallback', 'stable');
