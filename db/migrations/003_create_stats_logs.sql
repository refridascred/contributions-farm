-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, ratio, active, label, state) VALUES ('edge', 89.18, 97, 'edge', 'stable');
INSERT INTO stats_logs (region, ratio, active, label, state) VALUES ('fallback', 91.36, 19, 'local', 'local');
INSERT INTO stats_logs (region, ratio, active, label, state) VALUES ('legacy', 21.03, 69, 'blue', 'eu-west');
