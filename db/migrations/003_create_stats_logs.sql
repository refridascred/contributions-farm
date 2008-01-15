-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, active, score, weight, label) VALUES ('edge', 82, 4.52, 70.28, 'local');
INSERT INTO stats_logs (owner, active, score, weight, label) VALUES ('cached', 92, 23.97, 49.87, 'blue');
INSERT INTO stats_logs (owner, active, score, weight, label) VALUES ('latest', 31, 98.69, 85.41, 'stable');
