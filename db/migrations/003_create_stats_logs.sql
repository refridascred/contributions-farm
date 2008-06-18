-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, score, region, label) VALUES ('staging', 69.47, 'blue', 'blue');
INSERT INTO stats_logs (state, score, region, label) VALUES ('fallback', 91.54, 'legacy', 'edge');
INSERT INTO stats_logs (state, score, region, label) VALUES ('green', 80.77, 'fallback', 'blue');
