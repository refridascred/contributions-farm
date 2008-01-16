-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, active, owner, rank, count) VALUES ('blue', 61, 'fallback', 76, 70);
INSERT INTO stats_logs (token, active, owner, rank, count) VALUES ('latest', 28, 'blue', 30, 7);
