-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (score, owner, weight, active, label) VALUES (80.78, 'strict', 60.33, 63, 'standard');
INSERT INTO stats_logs (score, owner, weight, active, label) VALUES (87.31, 'stable', 34.69, 47, 'local');
