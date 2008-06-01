-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, active, rank, label, region) VALUES (54.55, 52, 53, 'edge', 'primary');
INSERT INTO stats_logs (score, active, rank, label, region) VALUES (76.98, 48, 26, 'staging', 'blue');
