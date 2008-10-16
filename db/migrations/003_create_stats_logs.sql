-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, region, token, owner) VALUES (66, 'cached', 'legacy', 'open');
INSERT INTO stats_logs (count, region, token, owner) VALUES (9, 'stable', 'standard', 'standard');
INSERT INTO stats_logs (count, region, token, owner) VALUES (38, 'green', 'primary', 'strict');
