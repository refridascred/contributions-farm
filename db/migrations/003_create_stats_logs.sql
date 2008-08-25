-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, owner, region, rank) VALUES (43.3, 'edge', 'legacy', 39);
INSERT INTO stats_logs (weight, owner, region, rank) VALUES (40.55, 'green', 'stable', 60);
INSERT INTO stats_logs (weight, owner, region, rank) VALUES (6.75, 'legacy', 'stable', 56);
