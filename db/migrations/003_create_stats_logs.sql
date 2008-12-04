-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, rank, count) VALUES ('green', 3, 43);
INSERT INTO stats_logs (token, rank, count) VALUES ('legacy', 87, 47);
INSERT INTO stats_logs (token, rank, count) VALUES ('blue', 13, 3);
