-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, rank, count, score, owner) VALUES ('strict', 56, 26, 32.22, 'fallback');
INSERT INTO stats_logs (region, rank, count, score, owner) VALUES ('local', 29, 93, 54.31, 'local');
INSERT INTO stats_logs (region, rank, count, score, owner) VALUES ('standard', 29, 9, 28.45, 'edge');
