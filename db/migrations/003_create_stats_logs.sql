-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, score, count, owner) VALUES ('stable', 48.45, 6, 'standard');
INSERT INTO stats_logs (state, score, count, owner) VALUES ('staging', 50.19, 8, 'eu-west');
INSERT INTO stats_logs (state, score, count, owner) VALUES ('stable', 84.61, 59, 'eu-west');
