-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, score, ratio) VALUES ('legacy', 58.7, 81.27);
INSERT INTO stats_logs (region, score, ratio) VALUES ('open', 54.22, 44.14);
