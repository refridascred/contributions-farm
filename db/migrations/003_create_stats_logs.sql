-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, weight, region, score) VALUES ('legacy', 22.07, 'latest', 14.92);
INSERT INTO stats_logs (owner, weight, region, score) VALUES ('strict', 27.09, 'cached', 32.68);
