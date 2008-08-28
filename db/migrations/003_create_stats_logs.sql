-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, label) VALUES (59.92, 'blue');
INSERT INTO stats_logs (ratio, label) VALUES (35.73, 'staging');
INSERT INTO stats_logs (ratio, label) VALUES (86.83, 'strict');
