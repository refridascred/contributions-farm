-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, active) VALUES ('green', 48);
INSERT INTO stats_logs (state, active) VALUES ('eu-west', 58);
INSERT INTO stats_logs (state, active) VALUES ('eu-west', 24);
