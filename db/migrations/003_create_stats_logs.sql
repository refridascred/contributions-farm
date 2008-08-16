-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, score, weight) VALUES ('legacy', 2.03, 8.2);
INSERT INTO stats_logs (region, score, weight) VALUES ('blue', 70.38, 54.13);
INSERT INTO stats_logs (region, score, weight) VALUES ('legacy', 68.58, 17.08);
