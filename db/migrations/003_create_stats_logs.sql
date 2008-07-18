-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, weight, label) VALUES ('latest', 68.76, 'staging');
INSERT INTO stats_logs (region, weight, label) VALUES ('local', 26.66, 'eu-west');
INSERT INTO stats_logs (region, weight, label) VALUES ('fallback', 32.45, 'strict');
