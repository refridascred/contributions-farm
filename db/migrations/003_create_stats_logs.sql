-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level, rank) VALUES ('green', 10, 6);
INSERT INTO stats_logs (region, level, rank) VALUES ('standard', 54, 59);
INSERT INTO stats_logs (region, level, rank) VALUES ('blue', 25, 16);
