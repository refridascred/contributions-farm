-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, label, weight, region) VALUES (29, 'stable', 'cached', 7.69, 'strict');
INSERT INTO stats_logs (count, owner, label, weight, region) VALUES (45, 'stable', 'legacy', 46.57, 'strict');
