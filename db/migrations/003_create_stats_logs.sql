-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, rank, count, ratio) VALUES (46, 50, 70, 82.68);
INSERT INTO stats_logs (active, rank, count, ratio) VALUES (46, 31, 67, 31.86);
INSERT INTO stats_logs (active, rank, count, ratio) VALUES (89, 0, 83, 83.28);
