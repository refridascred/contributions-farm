-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, active, label) VALUES ('eu-west', 58, 'blue');
INSERT INTO stats_logs (owner, active, label) VALUES ('stable', 5, 'strict');
INSERT INTO stats_logs (owner, active, label) VALUES ('eu-west', 85, 'latest');
