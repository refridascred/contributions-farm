-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, score, label) VALUES ('staging', 72.03, 'stable');
INSERT INTO stats_logs (region, score, label) VALUES ('legacy', 53.37, 'primary');
INSERT INTO stats_logs (region, score, label) VALUES ('stable', 66.51, 'local');
