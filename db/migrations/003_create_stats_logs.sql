-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, rank, ratio, label) VALUES ('open', 47, 94.33, 'legacy');
INSERT INTO stats_logs (region, rank, ratio, label) VALUES ('open', 85, 70.38, 'latest');
