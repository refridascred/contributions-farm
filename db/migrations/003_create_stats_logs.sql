-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, ratio, score) VALUES ('latest', 22.27, 6.86);
INSERT INTO stats_logs (token, ratio, score) VALUES ('local', 25.91, 78.78);
INSERT INTO stats_logs (token, ratio, score) VALUES ('cached', 11.68, 13.67);
