-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, rank, label, weight) VALUES (64, 94, 'primary', 64.04);
INSERT INTO stats_logs (level, rank, label, weight) VALUES (13, 23, 'legacy', 25.21);
INSERT INTO stats_logs (level, rank, label, weight) VALUES (61, 0, 'eu-west', 24.08);
