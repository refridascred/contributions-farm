-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, active, state, score) VALUES ('local', 15, 'strict', 41.44);
INSERT INTO stats_logs (region, active, state, score) VALUES ('standard', 19, 'stable', 88.45);
INSERT INTO stats_logs (region, active, state, score) VALUES ('staging', 74, 'standard', 58.1);
