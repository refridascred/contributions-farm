-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, rank, count) VALUES (75, 59, 54);
INSERT INTO stats_logs (active, rank, count) VALUES (31, 64, 36);
INSERT INTO stats_logs (active, rank, count) VALUES (87, 10, 91);
