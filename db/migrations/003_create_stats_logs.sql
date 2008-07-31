-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, region, score, state, owner) VALUES (66.1, 'latest', 23.49, 'fallback', 'staging');
INSERT INTO stats_logs (ratio, region, score, state, owner) VALUES (15.06, 'eu-west', 40.62, 'local', 'edge');
INSERT INTO stats_logs (ratio, region, score, state, owner) VALUES (21.86, 'stable', 42.63, 'edge', 'stable');
