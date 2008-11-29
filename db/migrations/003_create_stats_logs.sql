-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, level) VALUES ('green', 41);
INSERT INTO stats_logs (region, level) VALUES ('latest', 50);
INSERT INTO stats_logs (region, level) VALUES ('legacy', 83);
