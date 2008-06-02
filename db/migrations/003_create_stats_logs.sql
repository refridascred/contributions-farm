-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, owner, level, label) VALUES ('eu-west', 'primary', 2, 'fallback');
INSERT INTO stats_logs (state, owner, level, label) VALUES ('primary', 'local', 40, 'staging');
INSERT INTO stats_logs (state, owner, level, label) VALUES ('local', 'latest', 95, 'blue');
