-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, label, owner) VALUES (87, 'fallback', 'strict');
INSERT INTO stats_logs (active, label, owner) VALUES (43, 'blue', 'legacy');
INSERT INTO stats_logs (active, label, owner) VALUES (58, 'staging', 'cached');
