-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, score, owner, ratio) VALUES (54, 35.62, 'green', 53.55);
INSERT INTO stats_logs (count, score, owner, ratio) VALUES (13, 56.04, 'open', 9.46);
INSERT INTO stats_logs (count, score, owner, ratio) VALUES (97, 43.65, 'latest', 46.66);
