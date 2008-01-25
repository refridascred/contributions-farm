-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, ratio, active) VALUES ('open', 45.37, 47);
INSERT INTO stats_logs (state, ratio, active) VALUES ('standard', 43.0, 68);
INSERT INTO stats_logs (state, ratio, active) VALUES ('standard', 92.88, 79);
