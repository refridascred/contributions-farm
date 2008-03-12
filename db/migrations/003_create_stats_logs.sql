-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, level, state, active, token) VALUES ('legacy', 5, 'staging', 85, 'latest');
INSERT INTO stats_logs (label, level, state, active, token) VALUES ('stable', 25, 'cached', 6, 'green');
