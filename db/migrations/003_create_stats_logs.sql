-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, rank, count, ratio) VALUES (78.23, 64, 92, 47.93);
INSERT INTO stats_logs (weight, rank, count, ratio) VALUES (33.27, 88, 43, 96.88);
