-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, label, ratio, level, score) VALUES ('legacy', 'eu-west', 37.68, 43, 65.35);
INSERT INTO stats_logs (owner, label, ratio, level, score) VALUES ('local', 'legacy', 68.49, 17, 73.58);
