-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, label, token) VALUES (50.86, 'primary', 'local');
INSERT INTO stats_logs (ratio, label, token) VALUES (91.08, 'blue', 'local');
