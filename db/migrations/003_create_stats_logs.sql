-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, region, score, ratio) VALUES ('local', 'legacy', 6.86, 76.76);
INSERT INTO stats_logs (label, region, score, ratio) VALUES ('blue', 'standard', 56.99, 13.98);
INSERT INTO stats_logs (label, region, score, ratio) VALUES ('eu-west', 'blue', 14.02, 53.46);
