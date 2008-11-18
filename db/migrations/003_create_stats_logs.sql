-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, region, rank, level, label) VALUES ('strict', 'standard', 1, 96, 'legacy');
INSERT INTO stats_logs (state, region, rank, level, label) VALUES ('cached', 'fallback', 10, 27, 'local');
INSERT INTO stats_logs (state, region, rank, level, label) VALUES ('edge', 'cached', 78, 44, 'local');
