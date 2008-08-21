-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, state, ratio) VALUES (30, 'cached', 12.18);
INSERT INTO stats_logs (rank, state, ratio) VALUES (43, 'eu-west', 52.36);
INSERT INTO stats_logs (rank, state, ratio) VALUES (10, 'strict', 66.95);
