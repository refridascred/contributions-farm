-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, rank) VALUES (11.53, 47);
INSERT INTO stats_logs (ratio, rank) VALUES (31.04, 21);
INSERT INTO stats_logs (ratio, rank) VALUES (19.06, 60);
