-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, active, token, ratio, state) VALUES ('legacy', 15, 'blue', 29.28, 'legacy');
INSERT INTO commits_records (owner, active, token, ratio, state) VALUES ('green', 43, 'local', 21.69, 'green');
