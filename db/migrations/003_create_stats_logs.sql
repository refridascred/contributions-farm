-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, count, score, label) VALUES ('stable', 2, 8.86, 'green');
INSERT INTO stats_logs (region, count, score, label) VALUES ('eu-west', 51, 96.08, 'open');
