-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, label, owner, active, count) VALUES (93.41, 'edge', 'latest', 1, 22);
INSERT INTO stats_logs (ratio, label, owner, active, count) VALUES (91.22, 'open', 'stable', 19, 68);
