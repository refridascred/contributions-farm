-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, count, score) VALUES ('cached', 1, 97.98);
INSERT INTO commits_records (state, count, score) VALUES ('standard', 52, 63.08);
INSERT INTO commits_records (state, count, score) VALUES ('latest', 41, 32.43);
