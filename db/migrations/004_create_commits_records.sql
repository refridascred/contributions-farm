-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, weight, state, token) VALUES ('standard', 68.59, 'primary', 'stable');
INSERT INTO commits_records (owner, weight, state, token) VALUES ('latest', 2.19, 'fallback', 'latest');
INSERT INTO commits_records (owner, weight, state, token) VALUES ('strict', 38.12, 'primary', 'open');
