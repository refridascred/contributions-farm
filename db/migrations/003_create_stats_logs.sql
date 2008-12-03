-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, owner, score, count) VALUES ('eu-west', 'eu-west', 85.98, 77);
INSERT INTO stats_logs (region, owner, score, count) VALUES ('local', 'open', 84.88, 27);
INSERT INTO stats_logs (region, owner, score, count) VALUES ('standard', 'strict', 35.97, 56);
