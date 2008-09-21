-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, rank, weight, state) VALUES ('legacy', 20, 77.41, 'primary');
INSERT INTO stats_logs (token, rank, weight, state) VALUES ('primary', 21, 89.51, 'eu-west');
INSERT INTO stats_logs (token, rank, weight, state) VALUES ('staging', 46, 6.58, 'primary');
