-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, score, rank, label) VALUES ('staging', 40.08, 73, 'primary');
INSERT INTO stats_logs (state, score, rank, label) VALUES ('standard', 26.2, 82, 'legacy');
