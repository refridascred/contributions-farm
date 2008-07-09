-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio, count) VALUES ('legacy', 22.81, 90);
INSERT INTO stats_logs (owner, ratio, count) VALUES ('open', 86.52, 57);
INSERT INTO stats_logs (owner, ratio, count) VALUES ('local', 15.37, 67);
