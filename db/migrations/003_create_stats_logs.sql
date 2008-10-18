-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, level, count, label) VALUES ('fallback', 33, 9, 'fallback');
INSERT INTO stats_logs (owner, level, count, label) VALUES ('stable', 85, 81, 'fallback');
