-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, region, active, ratio) VALUES (14, 'cached', 60, 92.5);
INSERT INTO stats_logs (rank, region, active, ratio) VALUES (6, 'blue', 46, 34.51);
