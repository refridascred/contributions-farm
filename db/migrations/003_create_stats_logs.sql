-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, rank, owner, weight, active) VALUES ('eu-west', 0, 'edge', 97.76, 51);
INSERT INTO stats_logs (label, rank, owner, weight, active) VALUES ('primary', 88, 'stable', 45.8, 72);
INSERT INTO stats_logs (label, rank, owner, weight, active) VALUES ('eu-west', 37, 'legacy', 50.65, 54);
