-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, owner, region) VALUES (10, 'green', 'legacy');
INSERT INTO stats_logs (rank, owner, region) VALUES (58, 'stable', 'staging');
INSERT INTO stats_logs (rank, owner, region) VALUES (49, 'strict', 'legacy');
