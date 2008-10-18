-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, label, score, rank) VALUES (81.85, 60.69, 'green', 87.42, 68);
INSERT INTO stats_logs (ratio, weight, label, score, rank) VALUES (83.19, 76.96, 'legacy', 67.34, 12);
INSERT INTO stats_logs (ratio, weight, label, score, rank) VALUES (12.82, 93.08, 'eu-west', 13.78, 27);
