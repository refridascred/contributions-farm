-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, level) VALUES ('blue', 38);
INSERT INTO stats_logs (region, level) VALUES ('local', 85);
INSERT INTO stats_logs (region, level) VALUES ('fallback', 7);
