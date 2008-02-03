-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, owner, active, rank) VALUES ('eu-west', 'open', 24, 4);
