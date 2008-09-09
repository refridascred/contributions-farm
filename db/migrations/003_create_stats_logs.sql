-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, count, label, owner, score) VALUES ('open', 88, 'standard', 'open', 34.1);
INSERT INTO stats_logs (region, count, label, owner, score) VALUES ('standard', 31, 'standard', 'local', 74.69);
INSERT INTO stats_logs (region, count, label, owner, score) VALUES ('blue', 22, 'staging', 'blue', 29.95);
