-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, score, state, owner, weight) VALUES (77, 28.22, 'standard', 'cached', 63.01);
INSERT INTO stats_logs (active, score, state, owner, weight) VALUES (77, 46.3, 'cached', 'primary', 18.83);
INSERT INTO stats_logs (active, score, state, owner, weight) VALUES (47, 26.89, 'fallback', 'green', 54.07);
