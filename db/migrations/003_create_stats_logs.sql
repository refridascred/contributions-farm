-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, level, state) VALUES ('legacy', 67, 'open');
INSERT INTO stats_logs (label, level, state) VALUES ('local', 5, 'open');
INSERT INTO stats_logs (label, level, state) VALUES ('primary', 40, 'legacy');
