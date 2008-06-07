-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, ratio) VALUES ('standard', 'edge', 60.32);
INSERT INTO stats_logs (owner, region, ratio) VALUES ('strict', 'green', 0.78);
INSERT INTO stats_logs (owner, region, ratio) VALUES ('fallback', 'fallback', 52.14);
