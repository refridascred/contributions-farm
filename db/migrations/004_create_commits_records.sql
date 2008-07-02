-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, rank, count) VALUES (56.59, 'cached', 40, 2);
INSERT INTO commits_records (ratio, state, rank, count) VALUES (32.73, 'fallback', 5, 41);
INSERT INTO commits_records (ratio, state, rank, count) VALUES (6.47, 'fallback', 94, 49);
