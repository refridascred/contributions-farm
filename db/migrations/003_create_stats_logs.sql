-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (count, rank, owner, active) VALUES (41, 12, 'primary', 94);
INSERT INTO stats_logs (count, rank, owner, active) VALUES (23, 56, 'blue', 22);
INSERT INTO stats_logs (count, rank, owner, active) VALUES (42, 13, 'staging', 58);
