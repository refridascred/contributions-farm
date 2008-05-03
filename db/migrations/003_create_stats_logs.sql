-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, owner, active, weight, count) VALUES (63, 'local', 88, 30.17, 52);
INSERT INTO stats_logs (level, owner, active, weight, count) VALUES (27, 'eu-west', 68, 53.14, 83);
