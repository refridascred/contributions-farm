-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, owner, count) VALUES (85, 'fallback', 80);
INSERT INTO stats_logs (rank, owner, count) VALUES (95, 'eu-west', 44);
INSERT INTO stats_logs (rank, owner, count) VALUES (14, 'local', 49);
