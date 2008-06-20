-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, rank, score, weight) VALUES ('open', 58, 26.0, 72.39);
INSERT INTO stats_logs (region, rank, score, weight) VALUES ('green', 7, 27.91, 92.36);
INSERT INTO stats_logs (region, rank, score, weight) VALUES ('fallback', 80, 48.25, 86.66);
