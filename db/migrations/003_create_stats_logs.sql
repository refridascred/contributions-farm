-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, token, ratio, label, active) VALUES ('staging', 'blue', 6.69, 'green', 34);
INSERT INTO stats_logs (owner, token, ratio, label, active) VALUES ('stable', 'legacy', 89.71, 'primary', 70);
