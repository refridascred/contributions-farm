-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, owner, label) VALUES (49.35, 'edge', 'stable');
INSERT INTO stats_logs (ratio, owner, label) VALUES (27.42, 'strict', 'fallback');
INSERT INTO stats_logs (ratio, owner, label) VALUES (28.5, 'cached', 'primary');
