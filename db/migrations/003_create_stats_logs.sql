-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, token, score, label) VALUES ('stable', 'open', 64.09, 'staging');
INSERT INTO stats_logs (region, token, score, label) VALUES ('cached', 'legacy', 50.82, 'legacy');
