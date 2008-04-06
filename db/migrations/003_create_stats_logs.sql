-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, rank, owner, label) VALUES (58, 83, 'open', 'latest');
INSERT INTO stats_logs (level, rank, owner, label) VALUES (23, 60, 'local', 'primary');
