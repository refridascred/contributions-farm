-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, score, label, owner) VALUES (91.13, 55.9, 'cached', 'blue');
INSERT INTO stats_logs (weight, score, label, owner) VALUES (43.76, 67.61, 'primary', 'strict');
INSERT INTO stats_logs (weight, score, label, owner) VALUES (41.98, 73.88, 'legacy', 'strict');
