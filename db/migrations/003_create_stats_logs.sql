-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, label, count, active) VALUES ('eu-west', 'primary', 33, 33);
INSERT INTO stats_logs (owner, label, count, active) VALUES ('standard', 'eu-west', 28, 72);
INSERT INTO stats_logs (owner, label, count, active) VALUES ('stable', 'edge', 56, 74);
