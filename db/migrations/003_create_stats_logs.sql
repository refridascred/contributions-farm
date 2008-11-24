-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, label) VALUES (67.98, 'local');
INSERT INTO stats_logs (ratio, label) VALUES (69.87, 'local');
INSERT INTO stats_logs (ratio, label) VALUES (72.27, 'eu-west');
