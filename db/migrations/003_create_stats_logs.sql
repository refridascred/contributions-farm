-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, state, ratio, owner, label) VALUES (33, 'strict', 48.8, 'legacy', 'strict');
INSERT INTO stats_logs (active, state, ratio, owner, label) VALUES (77, 'legacy', 75.08, 'edge', 'latest');
