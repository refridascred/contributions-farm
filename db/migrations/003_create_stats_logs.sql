-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, active, label) VALUES ('local', 1, 'strict');
INSERT INTO stats_logs (region, active, label) VALUES ('edge', 63, 'fallback');
INSERT INTO stats_logs (region, active, label) VALUES ('cached', 6, 'legacy');
