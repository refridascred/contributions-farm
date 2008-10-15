-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, weight, region) VALUES ('cached', 90.12, 'eu-west');
INSERT INTO stats_logs (token, weight, region) VALUES ('strict', 26.67, 'cached');
INSERT INTO stats_logs (token, weight, region) VALUES ('edge', 28.77, 'primary');
