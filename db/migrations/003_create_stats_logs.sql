-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, state, score, weight) VALUES ('standard', 'blue', 17.24, 44.82);
INSERT INTO stats_logs (owner, state, score, weight) VALUES ('standard', 'edge', 34.94, 92.52);
INSERT INTO stats_logs (owner, state, score, weight) VALUES ('legacy', 'edge', 9.67, 91.96);
