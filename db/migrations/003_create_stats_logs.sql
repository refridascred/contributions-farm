-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, label, state) VALUES (81, 'green', 'fallback');
INSERT INTO stats_logs (rank, label, state) VALUES (34, 'blue', 'strict');
INSERT INTO stats_logs (rank, label, state) VALUES (87, 'legacy', 'open');
