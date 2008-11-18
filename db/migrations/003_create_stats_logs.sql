-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, active, owner, region, ratio) VALUES (37, 6, 'blue', 'open', 2.08);
INSERT INTO stats_logs (count, active, owner, region, ratio) VALUES (78, 18, 'staging', 'strict', 60.22);
INSERT INTO stats_logs (count, active, owner, region, ratio) VALUES (24, 34, 'local', 'cached', 36.1);
