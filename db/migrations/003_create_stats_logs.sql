-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, count, owner, rank) VALUES ('green', 75, 'stable', 85);
INSERT INTO stats_logs (region, count, owner, rank) VALUES ('fallback', 1, 'primary', 72);
INSERT INTO stats_logs (region, count, owner, rank) VALUES ('eu-west', 91, 'blue', 48);
