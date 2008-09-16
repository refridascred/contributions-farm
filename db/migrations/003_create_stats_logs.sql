-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, owner, ratio, level, weight) VALUES ('legacy', 'edge', 75.66, 67, 64.78);
INSERT INTO stats_logs (label, owner, ratio, level, weight) VALUES ('fallback', 'latest', 30.67, 19, 69.52);
INSERT INTO stats_logs (label, owner, ratio, level, weight) VALUES ('eu-west', 'local', 64.52, 10, 76.39);
