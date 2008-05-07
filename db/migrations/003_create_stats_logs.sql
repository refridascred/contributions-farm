-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, token, label, level) VALUES (68, 82.16, 'cached', 'strict', 77);
INSERT INTO stats_logs (rank, ratio, token, label, level) VALUES (28, 28.7, 'strict', 'blue', 28);
INSERT INTO stats_logs (rank, ratio, token, label, level) VALUES (18, 34.56, 'legacy', 'primary', 59);
