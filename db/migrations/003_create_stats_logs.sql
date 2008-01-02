-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, state, level, score, owner) VALUES (91.09, 'strict', 50, 77.72, 'blue');
INSERT INTO stats_logs (weight, state, level, score, owner) VALUES (21.85, 'eu-west', 44, 82.23, 'cached');
