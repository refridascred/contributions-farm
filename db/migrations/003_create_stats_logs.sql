-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, state, score, label, count) VALUES ('latest', 'green', 42.88, 'eu-west', 31);
INSERT INTO stats_logs (owner, state, score, label, count) VALUES ('cached', 'edge', 38.27, 'stable', 55);
INSERT INTO stats_logs (owner, state, score, label, count) VALUES ('fallback', 'legacy', 95.63, 'staging', 77);
