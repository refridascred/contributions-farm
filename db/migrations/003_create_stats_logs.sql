-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, owner, region, ratio) VALUES (11.11, 'standard', 'local', 71.62);
INSERT INTO stats_logs (score, owner, region, ratio) VALUES (19.97, 'legacy', 'open', 18.69);
