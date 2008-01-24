-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, ratio, weight, active, region) VALUES ('legacy', 59.8, 72.17, 66, 'eu-west');
INSERT INTO stats_logs (label, ratio, weight, active, region) VALUES ('legacy', 88.41, 91.16, 14, 'cached');
INSERT INTO stats_logs (label, ratio, weight, active, region) VALUES ('primary', 42.71, 32.86, 96, 'cached');
