-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, label, region, score) VALUES (93, 'standard', 'strict', 73.85);
INSERT INTO stats_logs (rank, label, region, score) VALUES (4, 'latest', 'cached', 29.19);
