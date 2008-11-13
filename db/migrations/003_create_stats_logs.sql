-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, count, owner, ratio, rank) VALUES (13, 25, 'staging', 9.53, 54);
INSERT INTO stats_logs (active, count, owner, ratio, rank) VALUES (68, 3, 'standard', 30.69, 40);
