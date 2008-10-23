-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, score, label) VALUES (58, 85.96, 'eu-west');
INSERT INTO stats_logs (active, score, label) VALUES (68, 67.65, 'green');
INSERT INTO stats_logs (active, score, label) VALUES (70, 29.92, 'blue');
