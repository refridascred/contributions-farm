-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (count, active, label) VALUES (73, 60, 'edge');
INSERT INTO stats_logs (count, active, label) VALUES (98, 12, 'cached');
INSERT INTO stats_logs (count, active, label) VALUES (23, 70, 'local');
