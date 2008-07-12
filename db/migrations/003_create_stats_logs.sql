-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, region, active, score, state) VALUES ('fallback', 'primary', 57, 67.07, 'standard');
INSERT INTO stats_logs (token, region, active, score, state) VALUES ('eu-west', 'edge', 37, 81.06, 'open');
INSERT INTO stats_logs (token, region, active, score, state) VALUES ('cached', 'primary', 23, 29.96, 'blue');
