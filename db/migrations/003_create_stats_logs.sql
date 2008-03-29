-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, level, owner, region) VALUES (7.69, 6, 'staging', 'standard');
INSERT INTO stats_logs (weight, level, owner, region) VALUES (47.75, 77, 'cached', 'legacy');
INSERT INTO stats_logs (weight, level, owner, region) VALUES (5.31, 52, 'staging', 'fallback');
