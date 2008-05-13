-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, state, owner, ratio) VALUES ('primary', 'green', 'open', 23.49);
INSERT INTO stats_logs (token, state, owner, ratio) VALUES ('latest', 'green', 'local', 23.86);
INSERT INTO stats_logs (token, state, owner, ratio) VALUES ('strict', 'standard', 'staging', 58.15);
