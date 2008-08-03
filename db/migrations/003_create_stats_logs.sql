-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (score, owner, ratio, rank) VALUES (35.61, 'green', 13.6, 82);
INSERT INTO stats_logs (score, owner, ratio, rank) VALUES (18.46, 'fallback', 42.86, 0);
INSERT INTO stats_logs (score, owner, ratio, rank) VALUES (54.1, 'open', 55.75, 30);
