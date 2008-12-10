-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, rank, label, count, weight) VALUES (87, 42, 'primary', 22, 9.49);
INSERT INTO stats_logs (level, rank, label, count, weight) VALUES (85, 18, 'standard', 16, 57.62);
