-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, owner, ratio) VALUES (26, 'edge', 23.36);
INSERT INTO stats_logs (level, owner, ratio) VALUES (97, 'staging', 48.53);
