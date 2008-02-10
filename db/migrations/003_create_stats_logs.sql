-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level) VALUES ('local', 44);
INSERT INTO stats_logs (region, level) VALUES ('green', 89);
INSERT INTO stats_logs (region, level) VALUES ('blue', 67);
