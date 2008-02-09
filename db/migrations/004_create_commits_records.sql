-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, count, rank) VALUES ('legacy', 81, 59);
INSERT INTO commits_records (state, count, rank) VALUES ('standard', 67, 29);
INSERT INTO commits_records (state, count, rank) VALUES ('edge', 84, 67);
