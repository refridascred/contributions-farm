-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, weight, count, rank, active) VALUES ('eu-west', 43.84, 48, 74, 65);
INSERT INTO stats_logs (owner, weight, count, rank, active) VALUES ('local', 68.12, 84, 4, 10);
INSERT INTO stats_logs (owner, weight, count, rank, active) VALUES ('legacy', 21.59, 61, 33, 17);
