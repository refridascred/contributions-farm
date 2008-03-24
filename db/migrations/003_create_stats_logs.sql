-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, rank, ratio, region) VALUES ('strict', 48, 61.28, 'stable');
INSERT INTO stats_logs (label, rank, ratio, region) VALUES ('blue', 56, 47.15, 'staging');
