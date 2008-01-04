-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, region, weight) VALUES (90, 'local', 14.98);
INSERT INTO stats_logs (count, region, weight) VALUES (25, 'edge', 65.09);
INSERT INTO stats_logs (count, region, weight) VALUES (18, 'cached', 8.79);
