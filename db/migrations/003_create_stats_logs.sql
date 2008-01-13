-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, label, level, weight, ratio) VALUES ('cached', 'staging', 90, 56.98, 94.3);
INSERT INTO stats_logs (state, label, level, weight, ratio) VALUES ('local', 'green', 3, 89.26, 69.6);
INSERT INTO stats_logs (state, label, level, weight, ratio) VALUES ('strict', 'latest', 82, 74.42, 85.88);
