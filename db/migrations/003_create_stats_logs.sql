-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, owner, region, active) VALUES (90, 'standard', 'cached', 91);
INSERT INTO stats_logs (level, owner, region, active) VALUES (69, 'fallback', 'strict', 32);
INSERT INTO stats_logs (level, owner, region, active) VALUES (24, 'eu-west', 'green', 49);
