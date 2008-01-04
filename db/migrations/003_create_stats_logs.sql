-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, owner, state, weight, rank) VALUES (26, 'edge', 'latest', 22.27, 24);
INSERT INTO stats_logs (level, owner, state, weight, rank) VALUES (3, 'legacy', 'staging', 71.17, 66);
