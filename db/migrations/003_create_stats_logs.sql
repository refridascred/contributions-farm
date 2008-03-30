-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, label) VALUES ('blue', 58.01, 'standard');
INSERT INTO stats_logs (region, weight, label) VALUES ('legacy', 89.94, 'stable');
INSERT INTO stats_logs (region, weight, label) VALUES ('staging', 60.87, 'edge');
