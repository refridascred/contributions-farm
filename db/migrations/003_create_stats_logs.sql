-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, rank, region, score, label) VALUES ('strict', 38, 'edge', 70.54, 'cached');
INSERT INTO stats_logs (token, rank, region, score, label) VALUES ('standard', 91, 'primary', 7.59, 'blue');
INSERT INTO stats_logs (token, rank, region, score, label) VALUES ('stable', 42, 'stable', 29.85, 'blue');
