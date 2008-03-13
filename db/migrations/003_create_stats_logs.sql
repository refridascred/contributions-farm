-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, owner, score, active, region) VALUES ('blue', 'standard', 67.17, 49, 'strict');
INSERT INTO stats_logs (state, owner, score, active, region) VALUES ('local', 'stable', 58.73, 50, 'staging');
