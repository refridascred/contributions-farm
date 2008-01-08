-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, rank, state, ratio) VALUES ('cached', 24, 'cached', 24.45);
INSERT INTO stats_logs (label, rank, state, ratio) VALUES ('eu-west', 48, 'green', 60.61);
