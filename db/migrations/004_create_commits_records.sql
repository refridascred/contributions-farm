-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, active, token, state) VALUES (40.64, 28, 'cached', 'legacy');
INSERT INTO commits_records (ratio, active, token, state) VALUES (31.64, 47, 'blue', 'standard');
INSERT INTO commits_records (ratio, active, token, state) VALUES (15.99, 6, 'staging', 'latest');
