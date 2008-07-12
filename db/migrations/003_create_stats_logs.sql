-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank, ratio, weight, level) VALUES ('primary', 94, 94.03, 62.1, 40);
INSERT INTO stats_logs (owner, rank, ratio, weight, level) VALUES ('green', 78, 5.84, 5.68, 20);
