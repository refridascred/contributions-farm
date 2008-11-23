-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, active, rank, count, ratio) VALUES ('standard', 67, 44, 94, 37.94);
INSERT INTO stats_logs (token, active, rank, count, ratio) VALUES ('primary', 63, 42, 6, 40.11);
