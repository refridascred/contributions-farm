-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, token, label, weight, score) VALUES ('eu-west', 'green', 'open', 86.77, 67.51);
INSERT INTO stats_logs (region, token, label, weight, score) VALUES ('cached', 'fallback', 'legacy', 88.8, 20.19);
INSERT INTO stats_logs (region, token, label, weight, score) VALUES ('edge', 'legacy', 'primary', 46.42, 51.59);
