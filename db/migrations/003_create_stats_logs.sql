-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, active, owner, score, count) VALUES ('fallback', 73, 'blue', 36.3, 2);
INSERT INTO stats_logs (label, active, owner, score, count) VALUES ('stable', 22, 'staging', 78.62, 33);
INSERT INTO stats_logs (label, active, owner, score, count) VALUES ('local', 52, 'primary', 56.09, 33);
