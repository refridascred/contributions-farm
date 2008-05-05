-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, count, owner, label) VALUES (54, 52, 'legacy', 'latest');
INSERT INTO stats_logs (active, count, owner, label) VALUES (23, 67, 'cached', 'legacy');
INSERT INTO stats_logs (active, count, owner, label) VALUES (12, 30, 'latest', 'green');
