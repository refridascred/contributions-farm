-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, rank, region, label) VALUES (4.53, 18, 'stable', 'blue');
INSERT INTO stats_logs (score, rank, region, label) VALUES (12.41, 24, 'green', 'local');
INSERT INTO stats_logs (score, rank, region, label) VALUES (90.18, 49, 'primary', 'standard');
