-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, state, weight) VALUES (81, 'local', 66.05);
INSERT INTO stats_logs (count, state, weight) VALUES (9, 'blue', 3.14);
INSERT INTO stats_logs (count, state, weight) VALUES (30, 'legacy', 70.6);
