-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, count, state, rank) VALUES (29, 77, 'green', 3);
INSERT INTO commits_records (active, count, state, rank) VALUES (23, 10, 'blue', 30);
INSERT INTO commits_records (active, count, state, rank) VALUES (19, 63, 'staging', 23);
