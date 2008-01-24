-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, level, region, rank) VALUES ('legacy', 73, 'standard', 91);
INSERT INTO stats_logs (token, level, region, rank) VALUES ('green', 38, 'stable', 15);
INSERT INTO stats_logs (token, level, region, rank) VALUES ('standard', 27, 'cached', 83);
