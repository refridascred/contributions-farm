-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, weight, state) VALUES ('edge', 34.4, 'latest');
INSERT INTO commits_records (token, weight, state) VALUES ('edge', 53.51, 'legacy');
