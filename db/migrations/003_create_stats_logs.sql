-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, count, owner, ratio) VALUES (89, 73, 'primary', 0.53);
INSERT INTO stats_logs (active, count, owner, ratio) VALUES (25, 97, 'cached', 20.52);
INSERT INTO stats_logs (active, count, owner, ratio) VALUES (25, 96, 'local', 30.89);
