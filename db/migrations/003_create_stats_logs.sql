-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, active, count, region) VALUES (93, 87, 16, 'open');
INSERT INTO stats_logs (rank, active, count, region) VALUES (95, 82, 31, 'stable');
INSERT INTO stats_logs (rank, active, count, region) VALUES (24, 50, 77, 'cached');
