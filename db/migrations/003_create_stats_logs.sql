-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, owner, rank, weight, level) VALUES (54.24, 'primary', 45, 88.88, 34);
INSERT INTO stats_logs (score, owner, rank, weight, level) VALUES (9.28, 'strict', 98, 94.91, 26);
INSERT INTO stats_logs (score, owner, rank, weight, level) VALUES (73.12, 'eu-west', 34, 67.87, 72);
