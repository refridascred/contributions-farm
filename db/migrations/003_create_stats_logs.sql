-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, count, ratio, active, rank) VALUES ('stable', 80, 30.56, 65, 43);
INSERT INTO stats_logs (token, count, ratio, active, rank) VALUES ('primary', 7, 90.5, 76, 99);
INSERT INTO stats_logs (token, count, ratio, active, rank) VALUES ('eu-west', 34, 97.5, 70, 73);
