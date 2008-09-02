-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, label, count) VALUES (94, 'strict', 74);
INSERT INTO stats_logs (active, label, count) VALUES (22, 'legacy', 89);
INSERT INTO stats_logs (active, label, count) VALUES (11, 'eu-west', 48);
