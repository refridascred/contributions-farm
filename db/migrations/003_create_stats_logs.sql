-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio, count, level) VALUES ('local', 62.34, 21, 65);
INSERT INTO stats_logs (owner, ratio, count, level) VALUES ('local', 43.05, 3, 33);
INSERT INTO stats_logs (owner, ratio, count, level) VALUES ('staging', 10.58, 76, 40);
