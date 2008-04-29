-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, count, weight) VALUES ('local', 91, 48.75);
INSERT INTO stats_logs (owner, count, weight) VALUES ('legacy', 61, 29.53);
INSERT INTO stats_logs (owner, count, weight) VALUES ('local', 11, 32.5);
