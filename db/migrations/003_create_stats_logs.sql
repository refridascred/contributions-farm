-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, score, label) VALUES (24.97, 20.07, 'edge');
INSERT INTO stats_logs (weight, score, label) VALUES (71.55, 28.53, 'primary');
