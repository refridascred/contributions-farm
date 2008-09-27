-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, region, owner, rank) VALUES (7, 'open', 'local', 72);
INSERT INTO stats_logs (active, region, owner, rank) VALUES (11, 'local', 'fallback', 60);
INSERT INTO stats_logs (active, region, owner, rank) VALUES (5, 'open', 'green', 3);
