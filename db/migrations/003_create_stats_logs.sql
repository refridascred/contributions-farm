-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, label, state, weight) VALUES ('eu-west', 'strict', 'stable', 31.28);
INSERT INTO stats_logs (token, label, state, weight) VALUES ('eu-west', 'edge', 'latest', 52.74);
