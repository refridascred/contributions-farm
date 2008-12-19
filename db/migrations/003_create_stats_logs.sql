-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, score, weight) VALUES ('green', 10.88, 48.24);
INSERT INTO stats_logs (state, score, weight) VALUES ('green', 67.6, 80.39);
INSERT INTO stats_logs (state, score, weight) VALUES ('eu-west', 26.47, 28.61);
