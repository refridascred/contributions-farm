-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, level, ratio, score) VALUES ('local', 28, 53.72, 77.52);
INSERT INTO stats_logs (state, level, ratio, score) VALUES ('edge', 13, 58.18, 40.59);
INSERT INTO stats_logs (state, level, ratio, score) VALUES ('standard', 59, 15.93, 36.3);
