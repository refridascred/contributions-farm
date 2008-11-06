-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, rank, owner) VALUES (88, 97, 'eu-west');
INSERT INTO stats_logs (level, rank, owner) VALUES (94, 5, 'stable');
INSERT INTO stats_logs (level, rank, owner) VALUES (11, 93, 'primary');
