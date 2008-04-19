-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, token, state, ratio, owner) VALUES ('stable', 'stable', 'stable', 81.73, 'legacy');
INSERT INTO stats_logs (region, token, state, ratio, owner) VALUES ('edge', 'latest', 'stable', 64.19, 'green');
