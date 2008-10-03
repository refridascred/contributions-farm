-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, score, token, weight) VALUES ('latest', 2.92, 'strict', 67.59);
INSERT INTO stats_logs (region, score, token, weight) VALUES ('green', 78.55, 'legacy', 9.07);
INSERT INTO stats_logs (region, score, token, weight) VALUES ('stable', 33.98, 'latest', 90.96);
