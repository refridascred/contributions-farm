-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, token, level, label) VALUES (73.75, 'open', 7, 'fallback');
INSERT INTO stats_logs (ratio, token, level, label) VALUES (2.07, 'legacy', 98, 'legacy');
INSERT INTO stats_logs (ratio, token, level, label) VALUES (78.82, 'fallback', 81, 'latest');
