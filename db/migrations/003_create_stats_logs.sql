-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, rank) VALUES (67.72, 'primary', 13);
INSERT INTO stats_logs (ratio, state, rank) VALUES (71.67, 'legacy', 17);
