-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, region) VALUES (88, 'standard');
INSERT INTO stats_logs (level, region) VALUES (12, 'staging');
INSERT INTO stats_logs (level, region) VALUES (37, 'legacy');
