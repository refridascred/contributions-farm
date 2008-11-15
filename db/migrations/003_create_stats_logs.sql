-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, count, token, active, region) VALUES (63, 54, 'staging', 99, 'stable');
INSERT INTO stats_logs (rank, count, token, active, region) VALUES (98, 78, 'latest', 67, 'standard');
INSERT INTO stats_logs (rank, count, token, active, region) VALUES (31, 75, 'fallback', 70, 'fallback');
