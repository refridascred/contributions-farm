-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, region, count, score) VALUES (6, 'edge', 17, 68.79);
INSERT INTO stats_logs (rank, region, count, score) VALUES (50, 'edge', 1, 81.04);
INSERT INTO stats_logs (rank, region, count, score) VALUES (18, 'green', 66, 97.86);
