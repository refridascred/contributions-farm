-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, label, weight, score) VALUES ('edge', 'open', 63.06, 69.69);
INSERT INTO stats_logs (owner, label, weight, score) VALUES ('stable', 'fallback', 57.35, 51.47);
