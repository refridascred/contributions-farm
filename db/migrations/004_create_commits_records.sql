-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, weight, state) VALUES ('stable', 24.75, 'blue');
INSERT INTO commits_records (owner, weight, state) VALUES ('edge', 74.83, 'eu-west');
