-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, score, ratio) VALUES (0, 'eu-west', 22.42, 33.96);
INSERT INTO stats_logs (count, owner, score, ratio) VALUES (22, 'blue', 33.92, 6.98);
INSERT INTO stats_logs (count, owner, score, ratio) VALUES (26, 'eu-west', 74.77, 76.2);
