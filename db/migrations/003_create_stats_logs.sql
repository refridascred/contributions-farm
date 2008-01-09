-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, label) VALUES (97.8, 'cached');
INSERT INTO stats_logs (ratio, label) VALUES (85.37, 'strict');
INSERT INTO stats_logs (ratio, label) VALUES (10.76, 'stable');
