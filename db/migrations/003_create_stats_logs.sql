-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, active, weight) VALUES (77.94, 77, 48.33);
INSERT INTO stats_logs (score, active, weight) VALUES (21.67, 79, 41.52);
INSERT INTO stats_logs (score, active, weight) VALUES (74.52, 77, 9.94);
