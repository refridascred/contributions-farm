-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, rank, level, region, token) VALUES (25.43, 54, 99, 'cached', 'blue');
INSERT INTO stats_logs (weight, rank, level, region, token) VALUES (5.62, 19, 97, 'open', 'primary');
INSERT INTO stats_logs (weight, rank, level, region, token) VALUES (58.95, 76, 31, 'standard', 'cached');
