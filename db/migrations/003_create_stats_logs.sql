-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, weight, score, state, count) VALUES ('cached', 10.72, 54.4, 'cached', 91);
INSERT INTO stats_logs (label, weight, score, state, count) VALUES ('fallback', 31.89, 49.56, 'stable', 97);
INSERT INTO stats_logs (label, weight, score, state, count) VALUES ('eu-west', 10.19, 83.17, 'strict', 10);
