-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, label, token) VALUES (38.96, 'eu-west', 'local');
INSERT INTO stats_logs (weight, label, token) VALUES (36.64, 'strict', 'local');
INSERT INTO stats_logs (weight, label, token) VALUES (37.39, 'strict', 'standard');
