-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, state, weight, rank) VALUES (33, 'primary', 81.08, 48);
INSERT INTO stats_logs (count, state, weight, rank) VALUES (38, 'latest', 27.47, 53);
INSERT INTO stats_logs (count, state, weight, rank) VALUES (35, 'cached', 46.17, 91);
