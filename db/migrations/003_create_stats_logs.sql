-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, token, state, owner) VALUES (48.65, 'stable', 'standard', 'strict');
INSERT INTO stats_logs (ratio, token, state, owner) VALUES (45.86, 'open', 'latest', 'latest');
