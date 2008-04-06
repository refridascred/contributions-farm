-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, label, owner) VALUES (1, 'latest', 'eu-west');
INSERT INTO stats_logs (level, label, owner) VALUES (6, 'legacy', 'blue');
