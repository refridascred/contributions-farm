-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, ratio, weight, region) VALUES ('fallback', 10.25, 47.24, 'eu-west');
INSERT INTO stats_logs (label, ratio, weight, region) VALUES ('local', 39.14, 54.14, 'fallback');
INSERT INTO stats_logs (label, ratio, weight, region) VALUES ('cached', 18.23, 55.03, 'green');
