-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, rank, token, weight) VALUES ('edge', 3, 'latest', 38.85);
INSERT INTO commits_records (state, rank, token, weight) VALUES ('legacy', 87, 'blue', 7.29);
INSERT INTO commits_records (state, rank, token, weight) VALUES ('stable', 80, 'open', 34.52);
