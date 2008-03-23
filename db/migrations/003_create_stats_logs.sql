-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, label, token, owner, state) VALUES (39, 'stable', 'standard', 'open', 'stable');
INSERT INTO stats_logs (active, label, token, owner, state) VALUES (10, 'blue', 'strict', 'fallback', 'strict');
INSERT INTO stats_logs (active, label, token, owner, state) VALUES (21, 'open', 'fallback', 'local', 'fallback');
