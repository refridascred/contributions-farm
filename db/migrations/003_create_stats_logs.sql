-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, state, score, count) VALUES ('stable', 'edge', 40.33, 1);
INSERT INTO stats_logs (region, state, score, count) VALUES ('eu-west', 'latest', 43.29, 92);
INSERT INTO stats_logs (region, state, score, count) VALUES ('cached', 'blue', 27.9, 12);
