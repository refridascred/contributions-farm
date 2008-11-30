-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, weight, region, rank, label) VALUES ('stable', 78.67, 'standard', 86, 'eu-west');
INSERT INTO stats_logs (owner, weight, region, rank, label) VALUES ('primary', 87.6, 'legacy', 32, 'edge');
INSERT INTO stats_logs (owner, weight, region, rank, label) VALUES ('strict', 65.95, 'staging', 1, 'primary');
