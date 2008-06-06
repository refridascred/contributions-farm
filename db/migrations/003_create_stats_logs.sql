-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token, label, rank) VALUES ('standard', 'primary', 'primary', 36);
INSERT INTO stats_logs (state, token, label, rank) VALUES ('legacy', 'strict', 'edge', 16);
