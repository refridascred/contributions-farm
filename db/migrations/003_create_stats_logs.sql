-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, level, active, ratio, state) VALUES ('blue', 3, 6, 33.67, 'open');
INSERT INTO stats_logs (label, level, active, ratio, state) VALUES ('strict', 93, 81, 49.19, 'stable');
INSERT INTO stats_logs (label, level, active, ratio, state) VALUES ('local', 6, 0, 82.84, 'legacy');
