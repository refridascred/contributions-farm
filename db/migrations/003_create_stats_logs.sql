-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, label, weight, active, rank) VALUES (86.68, 'stable', 78.29, 5, 79);
INSERT INTO stats_logs (score, label, weight, active, rank) VALUES (95.13, 'local', 64.13, 59, 96);
INSERT INTO stats_logs (score, label, weight, active, rank) VALUES (13.24, 'legacy', 43.23, 10, 22);
