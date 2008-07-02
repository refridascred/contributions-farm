-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, label) VALUES ('local', 'cached');
INSERT INTO stats_logs (region, label) VALUES ('blue', 'blue');
INSERT INTO stats_logs (region, label) VALUES ('eu-west', 'staging');
