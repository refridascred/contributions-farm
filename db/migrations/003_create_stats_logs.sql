-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, owner, ratio, score) VALUES ('fallback', 'legacy', 43.49, 3.88);
INSERT INTO stats_logs (region, owner, ratio, score) VALUES ('cached', 'staging', 17.4, 84.17);
