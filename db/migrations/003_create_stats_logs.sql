-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, label, state, count, level) VALUES ('strict', 'local', 'primary', 54, 70);
INSERT INTO stats_logs (region, label, state, count, level) VALUES ('staging', 'primary', 'primary', 92, 37);
INSERT INTO stats_logs (region, label, state, count, level) VALUES ('strict', 'stable', 'edge', 7, 58);
