-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, weight, level, state, count) VALUES (97, 42.58, 91, 'green', 57);
INSERT INTO stats_logs (rank, weight, level, state, count) VALUES (82, 5.09, 70, 'staging', 15);
INSERT INTO stats_logs (rank, weight, level, state, count) VALUES (45, 98.64, 35, 'legacy', 49);
