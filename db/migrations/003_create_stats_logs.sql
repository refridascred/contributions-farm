-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, region, owner, ratio) VALUES (43, 'primary', 'standard', 58.49);
INSERT INTO stats_logs (count, region, owner, ratio) VALUES (87, 'cached', 'standard', 72.05);
