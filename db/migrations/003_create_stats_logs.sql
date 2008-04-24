-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, token, level, state) VALUES ('edge', 'cached', 44, 'cached');
INSERT INTO stats_logs (region, token, level, state) VALUES ('staging', 'eu-west', 1, 'open');
INSERT INTO stats_logs (region, token, level, state) VALUES ('open', 'stable', 82, 'green');
