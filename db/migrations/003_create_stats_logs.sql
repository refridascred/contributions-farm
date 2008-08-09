-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, count, active, weight, region) VALUES ('fallback', 20, 88, 86.5, 'local');
INSERT INTO stats_logs (owner, count, active, weight, region) VALUES ('open', 12, 97, 45.82, 'blue');
