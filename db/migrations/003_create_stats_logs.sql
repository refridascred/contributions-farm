-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, label, count, level, ratio) VALUES ('eu-west', 'edge', 60, 92, 92.77);
INSERT INTO stats_logs (owner, label, count, level, ratio) VALUES ('legacy', 'green', 98, 26, 6.72);
INSERT INTO stats_logs (owner, label, count, level, ratio) VALUES ('stable', 'green', 58, 28, 15.26);
