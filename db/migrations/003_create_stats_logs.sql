-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, ratio, count, token) VALUES (24, 27.84, 56, 'fallback');
INSERT INTO stats_logs (rank, ratio, count, token) VALUES (80, 5.66, 84, 'local');
INSERT INTO stats_logs (rank, ratio, count, token) VALUES (65, 95.43, 95, 'local');
