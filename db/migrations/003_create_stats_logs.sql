-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, label, ratio, level) VALUES ('eu-west', 'blue', 28.71, 14);
INSERT INTO stats_logs (owner, label, ratio, level) VALUES ('strict', 'latest', 86.96, 69);
INSERT INTO stats_logs (owner, label, ratio, level) VALUES ('stable', 'fallback', 55.56, 8);
