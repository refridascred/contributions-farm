-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, token, score) VALUES ('blue', 'green', 15.04);
INSERT INTO stats_logs (region, token, score) VALUES ('eu-west', 'open', 7.06);
INSERT INTO stats_logs (region, token, score) VALUES ('stable', 'open', 38.27);
