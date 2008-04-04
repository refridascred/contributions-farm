-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, label, region) VALUES ('eu-west', 'green', 'fallback');
INSERT INTO stats_logs (token, label, region) VALUES ('legacy', 'green', 'cached');
INSERT INTO stats_logs (token, label, region) VALUES ('strict', 'edge', 'stable');
