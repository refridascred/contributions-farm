-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, rank, level, region) VALUES (70, 0, 19, 'legacy');
INSERT INTO stats_logs (active, rank, level, region) VALUES (31, 45, 32, 'primary');
INSERT INTO stats_logs (active, rank, level, region) VALUES (3, 28, 71, 'stable');
