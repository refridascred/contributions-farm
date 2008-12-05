-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, token, rank, region, count) VALUES (93, 'latest', 53, 'fallback', 8);
INSERT INTO stats_logs (active, token, rank, region, count) VALUES (78, 'eu-west', 75, 'blue', 16);
