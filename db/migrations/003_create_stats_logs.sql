-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, score, active, owner, count) VALUES ('blue', 84.91, 1, 'legacy', 28);
INSERT INTO stats_logs (label, score, active, owner, count) VALUES ('open', 74.24, 46, 'green', 68);
