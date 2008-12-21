-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, count, weight, label) VALUES ('local', 1, 80.38, 'green');
INSERT INTO stats_logs (region, count, weight, label) VALUES ('staging', 96, 77.28, 'edge');
INSERT INTO stats_logs (region, count, weight, label) VALUES ('latest', 55, 9.67, 'blue');
