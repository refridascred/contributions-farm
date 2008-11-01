-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, state, ratio) VALUES (38, 'local', 46.63);
INSERT INTO stats_logs (rank, state, ratio) VALUES (36, 'green', 3.49);
INSERT INTO stats_logs (rank, state, ratio) VALUES (29, 'open', 62.52);
