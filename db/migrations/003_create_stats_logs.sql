-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, ratio, count, state) VALUES ('primary', 82.62, 26, 'blue');
INSERT INTO stats_logs (region, ratio, count, state) VALUES ('strict', 74.35, 70, 'standard');
INSERT INTO stats_logs (region, ratio, count, state) VALUES ('local', 59.13, 9, 'legacy');
