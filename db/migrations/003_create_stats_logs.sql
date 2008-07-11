-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, weight, state) VALUES ('strict', 81.03, 'standard');
INSERT INTO stats_logs (region, weight, state) VALUES ('standard', 52.5, 'legacy');
INSERT INTO stats_logs (region, weight, state) VALUES ('edge', 14.02, 'open');
