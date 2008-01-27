-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, count, state, owner) VALUES (78.19, 67, 'blue', 'eu-west');
INSERT INTO stats_logs (ratio, count, state, owner) VALUES (75.98, 6, 'staging', 'strict');
INSERT INTO stats_logs (ratio, count, state, owner) VALUES (21.15, 97, 'edge', 'strict');
