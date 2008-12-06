-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, state, weight, rank) VALUES ('green', 'stable', 62.57, 47);
INSERT INTO commits_records (token, state, weight, rank) VALUES ('legacy', 'staging', 6.72, 46);
