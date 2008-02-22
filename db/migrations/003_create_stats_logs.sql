-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, level, token, weight, rank) VALUES ('cached', 85, 'standard', 6.01, 1);
INSERT INTO stats_logs (state, level, token, weight, rank) VALUES ('edge', 53, 'cached', 54.6, 31);
INSERT INTO stats_logs (state, level, token, weight, rank) VALUES ('cached', 8, 'edge', 65.29, 87);
