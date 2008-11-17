-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, token, active, owner, rank) VALUES ('green', 'cached', 0, 'green', 90);
INSERT INTO stats_logs (region, token, active, owner, rank) VALUES ('green', 'strict', 25, 'stable', 80);
