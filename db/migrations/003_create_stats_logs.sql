-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, rank, owner, state, score) VALUES (44.79, 83, 'fallback', 'stable', 75.75);
INSERT INTO stats_logs (ratio, rank, owner, state, score) VALUES (30.55, 32, 'eu-west', 'legacy', 96.35);
INSERT INTO stats_logs (ratio, rank, owner, state, score) VALUES (12.77, 39, 'latest', 'stable', 68.97);
