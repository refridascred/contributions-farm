-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, rank, token, region, weight) VALUES (99, 65, 'standard', 'standard', 18.33);
INSERT INTO stats_logs (count, rank, token, region, weight) VALUES (38, 2, 'standard', 'legacy', 13.07);
