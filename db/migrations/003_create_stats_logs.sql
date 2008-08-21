-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, token, level, count) VALUES (96, 'legacy', 92, 56);
INSERT INTO stats_logs (rank, token, level, count) VALUES (24, 'eu-west', 94, 25);
INSERT INTO stats_logs (rank, token, level, count) VALUES (10, 'cached', 90, 79);
