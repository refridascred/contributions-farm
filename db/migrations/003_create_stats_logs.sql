-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, owner, level, label) VALUES (99, 'latest', 62, 'stable');
INSERT INTO stats_logs (rank, owner, level, label) VALUES (46, 'standard', 33, 'stable');
