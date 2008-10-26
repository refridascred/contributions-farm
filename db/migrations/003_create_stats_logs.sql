-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, label) VALUES (41, 'eu-west');
INSERT INTO stats_logs (active, label) VALUES (33, 'blue');
INSERT INTO stats_logs (active, label) VALUES (46, 'strict');
