-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, score, label, owner, region) VALUES (56.43, 27.16, 'blue', 'edge', 'staging');
INSERT INTO stats_logs (ratio, score, label, owner, region) VALUES (58.54, 94.56, 'primary', 'legacy', 'fallback');
