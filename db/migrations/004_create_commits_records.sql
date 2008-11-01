-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, state, count, level) VALUES ('local', 'strict', 91, 11);
INSERT INTO commits_records (token, state, count, level) VALUES ('edge', 'eu-west', 60, 35);
INSERT INTO commits_records (token, state, count, level) VALUES ('open', 'edge', 49, 0);
