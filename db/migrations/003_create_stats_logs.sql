-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, level, ratio, score) VALUES ('standard', 79, 67.88, 40.17);
INSERT INTO stats_logs (state, level, ratio, score) VALUES ('blue', 72, 52.51, 18.96);
INSERT INTO stats_logs (state, level, ratio, score) VALUES ('standard', 67, 95.86, 37.54);
