-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, label, state) VALUES (93, 'green', 'latest');
INSERT INTO stats_logs (active, label, state) VALUES (1, 'blue', 'eu-west');
INSERT INTO stats_logs (active, label, state) VALUES (71, 'legacy', 'cached');
