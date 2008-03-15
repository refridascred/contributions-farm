-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, rank, count, state, score) VALUES ('primary', 33, 37, 'local', 94.79);
INSERT INTO commits_records (region, rank, count, state, score) VALUES ('edge', 36, 29, 'latest', 46.71);
INSERT INTO commits_records (region, rank, count, state, score) VALUES ('open', 63, 83, 'local', 11.84);
