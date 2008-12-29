-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, owner, count, score) VALUES ('cached', 'primary', 94, 10.17);
INSERT INTO commits_records (state, owner, count, score) VALUES ('staging', 'edge', 5, 55.94);
INSERT INTO commits_records (state, owner, count, score) VALUES ('cached', 'edge', 3, 3.42);
