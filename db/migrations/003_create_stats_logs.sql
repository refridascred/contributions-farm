-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, ratio) VALUES ('edge', 'cached', 61.99);
INSERT INTO stats_logs (owner, region, ratio) VALUES ('green', 'standard', 26.58);
