-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, ratio, score) VALUES ('latest', 12.85, 37.23);
INSERT INTO stats_logs (token, ratio, score) VALUES ('strict', 36.7, 78.75);
INSERT INTO stats_logs (token, ratio, score) VALUES ('blue', 54.25, 5.52);
