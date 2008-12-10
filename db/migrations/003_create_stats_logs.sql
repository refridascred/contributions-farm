-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, count, region, score, label) VALUES ('green', 92, 'standard', 17.96, 'cached');
INSERT INTO stats_logs (token, count, region, score, label) VALUES ('green', 44, 'local', 92.82, 'local');
INSERT INTO stats_logs (token, count, region, score, label) VALUES ('green', 3, 'legacy', 0.94, 'legacy');
