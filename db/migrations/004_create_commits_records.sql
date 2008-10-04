-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, state, ratio) VALUES (76, 'primary', 47.47);
INSERT INTO commits_records (rank, state, ratio) VALUES (32, 'cached', 73.49);
INSERT INTO commits_records (rank, state, ratio) VALUES (50, 'local', 27.25);
