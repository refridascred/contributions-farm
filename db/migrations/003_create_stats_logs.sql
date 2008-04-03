-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, score, level, owner) VALUES ('legacy', 27.23, 94, 'primary');
INSERT INTO stats_logs (label, score, level, owner) VALUES ('legacy', 49.76, 57, 'latest');
