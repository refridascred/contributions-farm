-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, region, level, active) VALUES (69, 'edge', 'strict', 86, 32);
INSERT INTO stats_logs (count, owner, region, level, active) VALUES (93, 'open', 'blue', 19, 94);
INSERT INTO stats_logs (count, owner, region, level, active) VALUES (47, 'stable', 'stable', 37, 40);
