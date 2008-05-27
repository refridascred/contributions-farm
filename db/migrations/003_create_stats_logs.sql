-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, active, owner) VALUES (70, 19, 'standard');
INSERT INTO stats_logs (count, active, owner) VALUES (46, 76, 'stable');
INSERT INTO stats_logs (count, active, owner) VALUES (73, 16, 'strict');
