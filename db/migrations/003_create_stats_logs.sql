-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, region, level, score) VALUES ('strict', 'standard', 74, 8.37);
INSERT INTO stats_logs (state, region, level, score) VALUES ('eu-west', 'edge', 64, 47.88);
