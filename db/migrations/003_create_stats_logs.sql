-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, rank, token, weight) VALUES (20, 41, 'local', 27.9);
INSERT INTO stats_logs (count, rank, token, weight) VALUES (75, 84, 'standard', 96.96);
