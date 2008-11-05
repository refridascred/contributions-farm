-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, token, state, owner) VALUES (36, 'standard', 'green', 'edge');
INSERT INTO stats_logs (active, token, state, owner) VALUES (67, 'primary', 'open', 'open');
INSERT INTO stats_logs (active, token, state, owner) VALUES (44, 'open', 'edge', 'green');
