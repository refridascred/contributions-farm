-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, level, rank, weight, count) VALUES ('local', 38, 27, 83.69, 47);
INSERT INTO stats_logs (token, level, rank, weight, count) VALUES ('staging', 97, 98, 23.78, 52);
INSERT INTO stats_logs (token, level, rank, weight, count) VALUES ('blue', 24, 16, 50.05, 81);
