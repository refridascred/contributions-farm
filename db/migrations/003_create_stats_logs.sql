-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, label, owner, rank) VALUES (57.77, 'cached', 'standard', 14);
INSERT INTO stats_logs (weight, label, owner, rank) VALUES (30.46, 'latest', 'fallback', 40);
