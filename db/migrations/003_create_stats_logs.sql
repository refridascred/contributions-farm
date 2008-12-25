-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, label, weight) VALUES ('fallback', 'strict', 'staging', 51.06);
INSERT INTO stats_logs (owner, region, label, weight) VALUES ('green', 'legacy', 'blue', 96.93);
