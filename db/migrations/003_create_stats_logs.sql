-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, count, level) VALUES ('green', 7, 26);
