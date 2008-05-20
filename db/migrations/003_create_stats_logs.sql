-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, count, owner, label) VALUES (62.92, 78, 'strict', 'staging');
INSERT INTO stats_logs (ratio, count, owner, label) VALUES (57.2, 45, 'primary', 'blue');
INSERT INTO stats_logs (ratio, count, owner, label) VALUES (25.2, 61, 'staging', 'eu-west');
