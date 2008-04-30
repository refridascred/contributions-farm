-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, region, rank, weight) VALUES ('standard', 'standard', 67, 12.51);
INSERT INTO stats_logs (owner, region, rank, weight) VALUES ('edge', 'edge', 54, 78.38);
