-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, active, region, owner, label) VALUES (6, 54, 'cached', 'latest', 'legacy');
INSERT INTO stats_logs (rank, active, region, owner, label) VALUES (11, 77, 'cached', 'local', 'strict');
INSERT INTO stats_logs (rank, active, region, owner, label) VALUES (36, 60, 'open', 'primary', 'latest');
