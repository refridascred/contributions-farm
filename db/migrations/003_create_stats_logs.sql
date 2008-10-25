-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, score, active, owner) VALUES ('stable', 82.93, 48, 'edge');
INSERT INTO stats_logs (region, score, active, owner) VALUES ('cached', 33.51, 72, 'staging');
