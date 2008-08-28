-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, active, label) VALUES (76.53, 87, 'legacy');
INSERT INTO stats_logs (ratio, active, label) VALUES (88.46, 89, 'eu-west');
INSERT INTO stats_logs (ratio, active, label) VALUES (12.0, 22, 'eu-west');
