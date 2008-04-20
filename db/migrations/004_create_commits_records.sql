-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, owner, ratio, token) VALUES ('staging', 'standard', 42.48, 'eu-west');
INSERT INTO commits_records (state, owner, ratio, token) VALUES ('eu-west', 'open', 53.06, 'blue');
