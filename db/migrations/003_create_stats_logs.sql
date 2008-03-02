-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, state, owner, ratio, token) VALUES (76.29, 'green', 'local', 96.06, 'standard');
INSERT INTO stats_logs (score, state, owner, ratio, token) VALUES (26.33, 'blue', 'staging', 27.21, 'stable');
