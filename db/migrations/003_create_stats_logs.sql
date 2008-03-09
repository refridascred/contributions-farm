-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, owner, level, region) VALUES (31.29, 'latest', 40, 'legacy');
INSERT INTO stats_logs (weight, owner, level, region) VALUES (43.43, 'eu-west', 86, 'legacy');
INSERT INTO stats_logs (weight, owner, level, region) VALUES (58.6, 'blue', 69, 'cached');
