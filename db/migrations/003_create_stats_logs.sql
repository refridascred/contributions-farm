-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, rank, state, level) VALUES ('strict', 70, 'standard', 40);
INSERT INTO stats_logs (region, rank, state, level) VALUES ('green', 45, 'cached', 52);
