-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (count, rank, active, owner) VALUES (30, 25, 38, 'strict');
INSERT INTO stats_logs (count, rank, active, owner) VALUES (27, 38, 75, 'blue');
INSERT INTO stats_logs (count, rank, active, owner) VALUES (78, 71, 56, 'legacy');
