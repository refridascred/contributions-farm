-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, ratio, state, score, label) VALUES ('fallback', 88.38, 'strict', 39.21, 'open');
INSERT INTO stats_logs (region, ratio, state, score, label) VALUES ('edge', 70.69, 'blue', 59.07, 'fallback');
INSERT INTO stats_logs (region, ratio, state, score, label) VALUES ('edge', 93.82, 'standard', 29.01, 'strict');
