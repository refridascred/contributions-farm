-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, state, ratio) VALUES ('standard', 'staging', 36.98);
INSERT INTO stats_logs (region, state, ratio) VALUES ('blue', 'primary', 11.79);
