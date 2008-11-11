-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, rank, count, score) VALUES ('eu-west', 53, 51, 33.73);
INSERT INTO stats_logs (owner, rank, count, score) VALUES ('staging', 90, 17, 31.76);
INSERT INTO stats_logs (owner, rank, count, score) VALUES ('legacy', 37, 49, 2.7);
