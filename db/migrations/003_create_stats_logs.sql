-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, owner, region, state) VALUES (75, 'blue', 'standard', 'local');
INSERT INTO stats_logs (level, owner, region, state) VALUES (91, 'fallback', 'cached', 'cached');
INSERT INTO stats_logs (level, owner, region, state) VALUES (77, 'green', 'cached', 'open');
