-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, state, owner, active, region) VALUES ('local', 'edge', 'stable', 18, 'primary');
INSERT INTO stats_logs (token, state, owner, active, region) VALUES ('standard', 'stable', 'open', 96, 'open');
INSERT INTO stats_logs (token, state, owner, active, region) VALUES ('green', 'standard', 'primary', 4, 'strict');
