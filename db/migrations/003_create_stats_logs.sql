-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, label, rank, active) VALUES (41, 'green', 61, 2);
INSERT INTO stats_logs (level, label, rank, active) VALUES (96, 'latest', 73, 32);
INSERT INTO stats_logs (level, label, rank, active) VALUES (74, 'open', 13, 1);
