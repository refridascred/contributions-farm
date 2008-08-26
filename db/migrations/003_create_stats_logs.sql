-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, owner, count, label) VALUES (48, 'green', 50, 'primary');
INSERT INTO stats_logs (active, owner, count, label) VALUES (14, 'strict', 29, 'cached');
INSERT INTO stats_logs (active, owner, count, label) VALUES (90, 'blue', 23, 'strict');
