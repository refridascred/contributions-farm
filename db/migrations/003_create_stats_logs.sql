-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, token, weight) VALUES ('fallback', 'strict', 2.96);
INSERT INTO stats_logs (label, token, weight) VALUES ('standard', 'primary', 9.02);
INSERT INTO stats_logs (label, token, weight) VALUES ('strict', 'cached', 65.98);
