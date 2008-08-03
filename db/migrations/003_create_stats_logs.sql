-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, score, owner) VALUES (49, 53.23, 'open');
INSERT INTO stats_logs (count, score, owner) VALUES (0, 73.52, 'cached');
INSERT INTO stats_logs (count, score, owner) VALUES (46, 36.73, 'eu-west');
