-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, count, label, score, region) VALUES ('standard', 21, 'staging', 21.27, 'latest');
INSERT INTO stats_logs (state, count, label, score, region) VALUES ('legacy', 47, 'stable', 86.78, 'latest');
