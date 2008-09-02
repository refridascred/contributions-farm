-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, token, ratio, weight) VALUES ('open', 'staging', 89.74, 82.77);
INSERT INTO stats_logs (owner, token, ratio, weight) VALUES ('edge', 'stable', 77.69, 67.77);
