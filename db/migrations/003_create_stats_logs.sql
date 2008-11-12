-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, label, score, ratio) VALUES (74, 'staging', 45.75, 76.43);
INSERT INTO stats_logs (level, label, score, ratio) VALUES (67, 'cached', 89.69, 43.37);
INSERT INTO stats_logs (level, label, score, ratio) VALUES (57, 'strict', 73.55, 48.82);
