-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, label, level) VALUES (86.97, 'staging', 87);
INSERT INTO stats_logs (score, label, level) VALUES (44.86, 'eu-west', 51);
INSERT INTO stats_logs (score, label, level) VALUES (11.96, 'green', 44);
