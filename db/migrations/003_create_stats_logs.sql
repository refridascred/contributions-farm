-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, active, level, weight, state) VALUES (78, 37, 11, 43.09, 'standard');
INSERT INTO stats_logs (rank, active, level, weight, state) VALUES (73, 29, 73, 66.4, 'staging');
INSERT INTO stats_logs (rank, active, level, weight, state) VALUES (38, 37, 57, 91.09, 'edge');
