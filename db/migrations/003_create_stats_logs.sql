-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, level, weight) VALUES ('blue', 24, 32.66);
INSERT INTO stats_logs (owner, level, weight) VALUES ('local', 36, 35.1);
INSERT INTO stats_logs (owner, level, weight) VALUES ('staging', 25, 64.36);
