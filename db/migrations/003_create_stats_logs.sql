-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, region) VALUES (80.93, 'strict', 'local');
INSERT INTO stats_logs (score, label, region) VALUES (92.9, 'primary', 'fallback');
INSERT INTO stats_logs (score, label, region) VALUES (24.45, 'local', 'eu-west');
