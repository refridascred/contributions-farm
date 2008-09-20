-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, owner, label, state) VALUES (20, 'open', 'cached', 'legacy');
INSERT INTO stats_logs (level, owner, label, state) VALUES (42, 'stable', 'blue', 'legacy');
