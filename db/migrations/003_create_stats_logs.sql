-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, score, label, region) VALUES (41, 71.92, 'local', 'standard');
INSERT INTO stats_logs (level, score, label, region) VALUES (94, 28.71, 'latest', 'legacy');
INSERT INTO stats_logs (level, score, label, region) VALUES (36, 16.33, 'green', 'green');
