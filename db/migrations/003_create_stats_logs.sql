-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level, token, ratio) VALUES ('stable', 1, 'strict', 24.61);
INSERT INTO stats_logs (region, level, token, ratio) VALUES ('stable', 56, 'stable', 57.13);
INSERT INTO stats_logs (region, level, token, ratio) VALUES ('blue', 73, 'legacy', 30.87);
