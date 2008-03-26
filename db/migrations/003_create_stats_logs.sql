-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, rank, label, owner, active) VALUES (12, 53, 'latest', 'local', 31);
INSERT INTO stats_logs (level, rank, label, owner, active) VALUES (32, 50, 'primary', 'fallback', 56);
