-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, region, state) VALUES (81, 'legacy', 'standard');
INSERT INTO stats_logs (level, region, state) VALUES (81, 'latest', 'stable');
INSERT INTO stats_logs (level, region, state) VALUES (70, 'local', 'green');
