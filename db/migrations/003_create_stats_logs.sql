-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, count, level) VALUES (55, 20, 87);
INSERT INTO stats_logs (rank, count, level) VALUES (0, 68, 69);
INSERT INTO stats_logs (rank, count, level) VALUES (1, 85, 98);
