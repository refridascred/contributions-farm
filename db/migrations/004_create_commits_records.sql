-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, state, rank) VALUES (29, 'standard', 64);
INSERT INTO commits_records (count, state, rank) VALUES (42, 'eu-west', 17);
INSERT INTO commits_records (count, state, rank) VALUES (36, 'local', 42);
