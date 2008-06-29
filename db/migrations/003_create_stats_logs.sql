-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, state, label, ratio) VALUES (25, 'blue', 'local', 76.55);
INSERT INTO stats_logs (rank, state, label, ratio) VALUES (51, 'cached', 'blue', 27.5);
INSERT INTO stats_logs (rank, state, label, ratio) VALUES (23, 'open', 'standard', 66.35);
