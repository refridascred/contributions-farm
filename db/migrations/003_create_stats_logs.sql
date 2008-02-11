-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, token, level, ratio, weight) VALUES (28, 'blue', 27, 80.79, 61.89);
INSERT INTO stats_logs (rank, token, level, ratio, weight) VALUES (21, 'eu-west', 13, 92.39, 81.12);
INSERT INTO stats_logs (rank, token, level, ratio, weight) VALUES (57, 'strict', 29, 6.35, 86.33);
