-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, active) VALUES ('open', 67);
INSERT INTO stats_logs (owner, active) VALUES ('legacy', 3);
INSERT INTO stats_logs (owner, active) VALUES ('local', 95);
