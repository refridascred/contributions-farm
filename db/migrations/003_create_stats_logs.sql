-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, level) VALUES ('blue', 80);
INSERT INTO stats_logs (label, level) VALUES ('blue', 86);
INSERT INTO stats_logs (label, level) VALUES ('local', 41);
