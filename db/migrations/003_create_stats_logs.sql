-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, state, score, weight) VALUES (3, 'cached', 61.48, 60.25);
INSERT INTO stats_logs (count, state, score, weight) VALUES (75, 'eu-west', 1.54, 54.56);
INSERT INTO stats_logs (count, state, score, weight) VALUES (86, 'strict', 36.37, 2.13);
