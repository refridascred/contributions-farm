-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, region, weight) VALUES (63, 'strict', 25.96);
INSERT INTO stats_logs (rank, region, weight) VALUES (80, 'cached', 83.54);
