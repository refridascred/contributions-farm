-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, weight, owner, label, active) VALUES (16, 46.01, 'edge', 'blue', 35);
INSERT INTO stats_logs (level, weight, owner, label, active) VALUES (23, 83.86, 'open', 'standard', 96);
INSERT INTO stats_logs (level, weight, owner, label, active) VALUES (46, 5.55, 'blue', 'eu-west', 46);
