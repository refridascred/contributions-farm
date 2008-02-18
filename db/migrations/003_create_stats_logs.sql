-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, label, rank, weight) VALUES (39, 'strict', 91, 57.2);
INSERT INTO stats_logs (count, label, rank, weight) VALUES (4, 'latest', 74, 38.58);
