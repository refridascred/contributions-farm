-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, score, region, state, owner) VALUES ('local', 96.11, 'latest', 'primary', 'local');
INSERT INTO stats_logs (label, score, region, state, owner) VALUES ('stable', 98.71, 'staging', 'strict', 'cached');
