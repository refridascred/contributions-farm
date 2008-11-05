-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, weight, label, active, level) VALUES (25.55, 6.56, 'open', 5, 63);
INSERT INTO stats_logs (score, weight, label, active, level) VALUES (3.35, 26.85, 'open', 81, 17);
