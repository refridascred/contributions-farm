-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    ratio REAL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, token, ratio, region, weight) VALUES (51, 'green', 2.94, 'cached', 49.02);
INSERT INTO stats_logs (rank, token, ratio, region, weight) VALUES (63, 'local', 62.55, 'blue', 39.29);
