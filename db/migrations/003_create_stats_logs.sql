-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, label, weight) VALUES ('legacy', 'staging', 67.93);
INSERT INTO stats_logs (token, label, weight) VALUES ('strict', 'eu-west', 8.98);
