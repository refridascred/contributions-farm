-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (score, rank, ratio, count) VALUES (9.97, 19, 29.93, 81);
INSERT INTO stats_logs (score, rank, ratio, count) VALUES (91.89, 42, 63.8, 87);
INSERT INTO stats_logs (score, rank, ratio, count) VALUES (51.61, 84, 42.4, 95);
