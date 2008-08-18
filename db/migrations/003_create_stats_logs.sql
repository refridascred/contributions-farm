-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, level, state) VALUES ('standard', 25, 'primary');
INSERT INTO stats_logs (owner, level, state) VALUES ('cached', 40, 'latest');
INSERT INTO stats_logs (owner, level, state) VALUES ('local', 85, 'legacy');
