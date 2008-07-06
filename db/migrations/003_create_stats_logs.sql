-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, rank, region, label) VALUES (43, 28, 'green', 'stable');
INSERT INTO stats_logs (active, rank, region, label) VALUES (79, 72, 'green', 'cached');
