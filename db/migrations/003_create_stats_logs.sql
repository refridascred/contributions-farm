-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, owner, token, count, active) VALUES (86.6, 'staging', 'edge', 32, 59);
INSERT INTO stats_logs (ratio, owner, token, count, active) VALUES (57.22, 'cached', 'local', 44, 15);
INSERT INTO stats_logs (ratio, owner, token, count, active) VALUES (27.99, 'eu-west', 'legacy', 9, 43);
