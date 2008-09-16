-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, rank, region) VALUES (50.98, 'edge', 58, 'legacy');
INSERT INTO stats_logs (score, label, rank, region) VALUES (57.57, 'staging', 45, 'cached');
