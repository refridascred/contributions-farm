-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, active, label) VALUES ('cached', 42, 'eu-west');
INSERT INTO stats_logs (owner, active, label) VALUES ('cached', 6, 'blue');
INSERT INTO stats_logs (owner, active, label) VALUES ('edge', 63, 'eu-west');
