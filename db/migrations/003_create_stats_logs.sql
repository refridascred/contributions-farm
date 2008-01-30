-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, rank, owner, level) VALUES ('staging', 73, 'legacy', 6);
INSERT INTO stats_logs (label, rank, owner, level) VALUES ('blue', 35, 'green', 3);
INSERT INTO stats_logs (label, rank, owner, level) VALUES ('stable', 96, 'standard', 2);
