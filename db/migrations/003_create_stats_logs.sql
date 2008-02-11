-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, weight, level, ratio) VALUES ('open', 71.86, 87, 69.14);
INSERT INTO stats_logs (state, weight, level, ratio) VALUES ('standard', 36.45, 77, 46.58);
