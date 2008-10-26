-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, rank, region) VALUES (54, 56, 'primary');
INSERT INTO stats_logs (active, rank, region) VALUES (49, 29, 'legacy');
INSERT INTO stats_logs (active, rank, region) VALUES (82, 94, 'edge');
