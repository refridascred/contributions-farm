-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, region, active, token) VALUES ('staging', 'local', 41, 'staging');
INSERT INTO stats_logs (label, region, active, token) VALUES ('standard', 'strict', 73, 'primary');
INSERT INTO stats_logs (label, region, active, token) VALUES ('local', 'edge', 92, 'local');
