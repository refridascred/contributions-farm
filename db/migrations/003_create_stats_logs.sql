-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, active) VALUES ('fallback', 99);
INSERT INTO stats_logs (region, active) VALUES ('blue', 40);
INSERT INTO stats_logs (region, active) VALUES ('local', 67);
