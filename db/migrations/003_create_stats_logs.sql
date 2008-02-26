-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, rank, count) VALUES (68, 67, 34);
INSERT INTO stats_logs (active, rank, count) VALUES (45, 2, 38);
INSERT INTO stats_logs (active, rank, count) VALUES (42, 71, 58);
