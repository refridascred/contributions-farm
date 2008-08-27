-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, owner, state, level, label) VALUES ('fallback', 'cached', 'local', 64, 'eu-west');
INSERT INTO stats_logs (region, owner, state, level, label) VALUES ('legacy', 'open', 'blue', 42, 'blue');
