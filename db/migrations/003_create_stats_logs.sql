-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, rank, active, region, token) VALUES ('edge', 3, 74, 'primary', 'staging');
INSERT INTO stats_logs (label, rank, active, region, token) VALUES ('green', 81, 65, 'fallback', 'strict');
