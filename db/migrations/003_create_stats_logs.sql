-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, region, count, label, token) VALUES (38.05, 'local', 63, 'eu-west', 'strict');
