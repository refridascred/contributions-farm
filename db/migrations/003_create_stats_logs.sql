-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, label, active) VALUES ('latest', 'fallback', 71);
INSERT INTO stats_logs (state, label, active) VALUES ('blue', 'stable', 74);
INSERT INTO stats_logs (state, label, active) VALUES ('eu-west', 'green', 23);
