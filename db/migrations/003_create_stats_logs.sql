-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, ratio, score, label, state) VALUES ('eu-west', 24.47, 39.51, 'staging', 'standard');
INSERT INTO stats_logs (region, ratio, score, label, state) VALUES ('latest', 48.98, 24.88, 'standard', 'eu-west');
INSERT INTO stats_logs (region, ratio, score, label, state) VALUES ('green', 90.67, 57.69, 'primary', 'fallback');
