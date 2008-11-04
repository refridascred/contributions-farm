-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, level, label) VALUES (36.39, 87, 'strict');
INSERT INTO stats_logs (score, level, label) VALUES (86.28, 11, 'primary');
INSERT INTO stats_logs (score, level, label) VALUES (40.76, 2, 'fallback');
