-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, score, count) VALUES ('latest', 88.19, 13);
INSERT INTO stats_logs (owner, score, count) VALUES ('green', 92.95, 22);
INSERT INTO stats_logs (owner, score, count) VALUES ('blue', 16.71, 4);
