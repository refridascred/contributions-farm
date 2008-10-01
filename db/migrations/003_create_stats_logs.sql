-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, score, owner, label) VALUES (70, 61.6, 'legacy', 'latest');
INSERT INTO stats_logs (count, score, owner, label) VALUES (95, 16.95, 'fallback', 'staging');
