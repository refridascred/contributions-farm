-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, label) VALUES (50, 'staging');
INSERT INTO stats_logs (active, label) VALUES (72, 'green');
INSERT INTO stats_logs (active, label) VALUES (57, 'staging');
