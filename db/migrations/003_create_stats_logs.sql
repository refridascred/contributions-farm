-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, region, token, score, label) VALUES (77, 'strict', 'edge', 38.61, 'primary');
INSERT INTO stats_logs (count, region, token, score, label) VALUES (43, 'standard', 'stable', 4.28, 'stable');
