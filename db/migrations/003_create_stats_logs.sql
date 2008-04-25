-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, token, owner, weight, count) VALUES (25, 'latest', 'stable', 41.18, 83);
INSERT INTO stats_logs (active, token, owner, weight, count) VALUES (54, 'open', 'blue', 43.44, 72);
