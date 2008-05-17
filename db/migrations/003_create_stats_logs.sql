-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, state, level) VALUES (44.55, 'cached', 16);
INSERT INTO stats_logs (score, state, level) VALUES (40.27, 'blue', 52);
INSERT INTO stats_logs (score, state, level) VALUES (73.83, 'latest', 15);
