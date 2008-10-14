-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, count, weight, owner) VALUES (78, 90, 96.21, 'legacy');
INSERT INTO stats_logs (rank, count, weight, owner) VALUES (20, 59, 64.5, 'stable');
INSERT INTO stats_logs (rank, count, weight, owner) VALUES (0, 0, 22.07, 'green');
