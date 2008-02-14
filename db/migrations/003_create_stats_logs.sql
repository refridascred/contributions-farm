-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, owner, level, count, state) VALUES ('green', 'latest', 10, 55, 'eu-west');
INSERT INTO stats_logs (token, owner, level, count, state) VALUES ('legacy', 'latest', 2, 28, 'green');
