-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, count, active, owner) VALUES (0, 39, 5, 'cached');
INSERT INTO stats_logs (level, count, active, owner) VALUES (53, 55, 26, 'open');
INSERT INTO stats_logs (level, count, active, owner) VALUES (31, 12, 13, 'open');
