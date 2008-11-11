-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, active, label, weight, ratio) VALUES ('latest', 29, 'blue', 63.85, 92.86);
INSERT INTO stats_logs (owner, active, label, weight, ratio) VALUES ('standard', 31, 'local', 34.93, 14.02);
INSERT INTO stats_logs (owner, active, label, weight, ratio) VALUES ('eu-west', 28, 'standard', 88.68, 42.33);
