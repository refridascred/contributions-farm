-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, owner, weight) VALUES (8, 'local', 17.38);
INSERT INTO stats_logs (active, owner, weight) VALUES (64, 'edge', 1.89);
INSERT INTO stats_logs (active, owner, weight) VALUES (86, 'open', 4.25);
