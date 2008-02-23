-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, level, score) VALUES ('primary', 10, 70.65);
INSERT INTO stats_logs (label, level, score) VALUES ('green', 26, 26.44);
INSERT INTO stats_logs (label, level, score) VALUES ('cached', 13, 95.22);
