-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, ratio, active, weight) VALUES ('edge', 31.05, 21, 77.49);
INSERT INTO stats_logs (state, ratio, active, weight) VALUES ('eu-west', 76.61, 18, 21.62);
INSERT INTO stats_logs (state, ratio, active, weight) VALUES ('edge', 42.82, 2, 78.39);
