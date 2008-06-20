-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, label, active) VALUES ('open', 'primary', 45);
INSERT INTO stats_logs (owner, label, active) VALUES ('green', 'blue', 16);
INSERT INTO stats_logs (owner, label, active) VALUES ('staging', 'standard', 42);
