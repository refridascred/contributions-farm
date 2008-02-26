-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, score, owner) VALUES (90, 1.19, 'legacy');
INSERT INTO stats_logs (count, score, owner) VALUES (21, 48.01, 'blue');
INSERT INTO stats_logs (count, score, owner) VALUES (70, 21.79, 'staging');
