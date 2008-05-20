-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, count, state, weight, ratio) VALUES ('staging', 26, 'edge', 37.67, 56.41);
INSERT INTO stats_logs (region, count, state, weight, ratio) VALUES ('primary', 49, 'green', 2.93, 55.25);
INSERT INTO stats_logs (region, count, state, weight, ratio) VALUES ('eu-west', 34, 'legacy', 88.31, 58.59);
