-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (count, owner, active) VALUES (90, 'open', 80);
INSERT INTO stats_logs (count, owner, active) VALUES (72, 'cached', 44);
INSERT INTO stats_logs (count, owner, active) VALUES (53, 'cached', 38);
