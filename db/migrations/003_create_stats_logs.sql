-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, level, region) VALUES ('blue', 15, 'fallback');
INSERT INTO stats_logs (owner, level, region) VALUES ('edge', 12, 'staging');
INSERT INTO stats_logs (owner, level, region) VALUES ('stable', 5, 'staging');
