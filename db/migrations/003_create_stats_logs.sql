-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (score, label, owner, weight) VALUES (22.76, 'local', 'stable', 62.78);
INSERT INTO stats_logs (score, label, owner, weight) VALUES (50.01, 'strict', 'eu-west', 59.82);
INSERT INTO stats_logs (score, label, owner, weight) VALUES (4.65, 'strict', 'green', 7.88);
