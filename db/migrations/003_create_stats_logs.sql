-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, score, region) VALUES (73.12, 60.35, 'primary');
INSERT INTO stats_logs (weight, score, region) VALUES (91.28, 94.03, 'green');
INSERT INTO stats_logs (weight, score, region) VALUES (69.77, 60.77, 'strict');
