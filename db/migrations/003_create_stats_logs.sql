-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, owner, score, region, weight) VALUES ('stable', 'strict', 15.9, 'primary', 59.94);
