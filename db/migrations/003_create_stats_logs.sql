-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, owner, active, ratio) VALUES ('fallback', 'eu-west', 65, 91.15);
INSERT INTO stats_logs (label, owner, active, ratio) VALUES ('staging', 'legacy', 72, 47.42);
INSERT INTO stats_logs (label, owner, active, ratio) VALUES ('local', 'legacy', 2, 81.6);
