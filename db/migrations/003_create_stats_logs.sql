-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, rank, ratio, region, weight) VALUES ('legacy', 97, 9.8, 'stable', 2.86);
INSERT INTO stats_logs (state, rank, ratio, region, weight) VALUES ('stable', 82, 75.76, 'open', 97.35);
