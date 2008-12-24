-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, ratio, label, score, rank) VALUES (18, 10.52, 'eu-west', 78.83, 89);
INSERT INTO stats_logs (count, ratio, label, score, rank) VALUES (24, 17.01, 'open', 7.92, 9);
INSERT INTO stats_logs (count, ratio, label, score, rank) VALUES (90, 65.1, 'latest', 16.27, 13);
