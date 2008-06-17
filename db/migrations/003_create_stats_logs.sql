-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, label) VALUES (35.37, 'edge');
INSERT INTO stats_logs (ratio, label) VALUES (94.51, 'edge');
