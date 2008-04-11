-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, region, owner, weight) VALUES (92, 'stable', 'legacy', 61.46);
INSERT INTO stats_logs (count, region, owner, weight) VALUES (87, 'open', 'local', 48.46);
