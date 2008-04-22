-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, region, ratio) VALUES (89, 'local', 73.39);
INSERT INTO stats_logs (count, region, ratio) VALUES (88, 'standard', 34.63);
INSERT INTO stats_logs (count, region, ratio) VALUES (16, 'eu-west', 31.99);
