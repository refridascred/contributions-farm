-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, label, active) VALUES ('edge', 'local', 7);
INSERT INTO stats_logs (owner, label, active) VALUES ('legacy', 'staging', 96);
INSERT INTO stats_logs (owner, label, active) VALUES ('eu-west', 'cached', 20);
