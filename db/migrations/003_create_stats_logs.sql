-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, rank, state, count, ratio) VALUES (2.35, 56, 'green', 83, 42.2);
INSERT INTO stats_logs (weight, rank, state, count, ratio) VALUES (31.85, 44, 'eu-west', 68, 41.19);
