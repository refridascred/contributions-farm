-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, ratio, label, owner, level) VALUES (71.96, 5.79, 'primary', 'stable', 14);
INSERT INTO stats_logs (score, ratio, label, owner, level) VALUES (70.82, 10.87, 'local', 'eu-west', 50);
