-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, rank, active, weight, owner) VALUES ('latest', 91, 41, 92.48, 'cached');
