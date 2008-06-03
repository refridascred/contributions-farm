-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, count) VALUES ('strict', 9);
INSERT INTO stats_logs (region, count) VALUES ('staging', 51);
INSERT INTO stats_logs (region, count) VALUES ('strict', 93);
