-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, level, region, score) VALUES ('primary', 55, 'primary', 50.64);
INSERT INTO stats_logs (state, level, region, score) VALUES ('blue', 14, 'edge', 90.8);
INSERT INTO stats_logs (state, level, region, score) VALUES ('standard', 58, 'local', 66.5);
