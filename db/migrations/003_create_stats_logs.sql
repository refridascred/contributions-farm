-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, label, token, state) VALUES ('open', 'latest', 'local', 'blue');
INSERT INTO stats_logs (owner, label, token, state) VALUES ('green', 'green', 'cached', 'open');
