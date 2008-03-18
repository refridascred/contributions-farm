-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, rank, count, region, ratio) VALUES (26.94, 21, 99, 'standard', 46.43);
INSERT INTO stats_logs (score, rank, count, region, ratio) VALUES (28.3, 32, 59, 'blue', 81.12);
