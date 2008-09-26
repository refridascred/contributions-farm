-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, count, rank) VALUES ('strict', 44, 41);
INSERT INTO commits_records (state, count, rank) VALUES ('open', 56, 59);
INSERT INTO commits_records (state, count, rank) VALUES ('cached', 12, 55);
