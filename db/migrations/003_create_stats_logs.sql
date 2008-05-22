-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, token, active, level, state) VALUES (50.58, 'stable', 13, 66, 'staging');
INSERT INTO stats_logs (ratio, token, active, level, state) VALUES (58.84, 'open', 92, 49, 'strict');
