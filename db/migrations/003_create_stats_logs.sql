-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, active, score, rank, owner) VALUES ('latest', 79, 98.11, 52, 'latest');
INSERT INTO stats_logs (state, active, score, rank, owner) VALUES ('standard', 68, 22.13, 96, 'fallback');
INSERT INTO stats_logs (state, active, score, rank, owner) VALUES ('fallback', 76, 66.67, 47, 'green');
