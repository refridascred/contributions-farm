-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, weight, rank, region) VALUES ('open', 19.52, 16, 'staging');
INSERT INTO stats_logs (label, weight, rank, region) VALUES ('primary', 52.43, 12, 'edge');
