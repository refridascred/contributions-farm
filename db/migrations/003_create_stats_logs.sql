-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, region, score, state, weight) VALUES (60, 'local', 28.74, 'eu-west', 6.32);
INSERT INTO stats_logs (active, region, score, state, weight) VALUES (32, 'edge', 21.28, 'local', 22.33);
