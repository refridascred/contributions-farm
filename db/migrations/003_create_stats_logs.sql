-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, region, active, score) VALUES (48, 'blue', 9, 26.75);
INSERT INTO stats_logs (rank, region, active, score) VALUES (47, 'stable', 11, 82.32);
INSERT INTO stats_logs (rank, region, active, score) VALUES (56, 'open', 57, 46.62);
