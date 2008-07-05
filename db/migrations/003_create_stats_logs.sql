-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, rank, level, region) VALUES (52, 7, 40, 'stable');
INSERT INTO stats_logs (active, rank, level, region) VALUES (10, 39, 74, 'strict');
