-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, weight, token, count) VALUES ('green', 83.46, 'cached', 94);
INSERT INTO commits_records (state, weight, token, count) VALUES ('legacy', 30.84, 'fallback', 35);
INSERT INTO commits_records (state, weight, token, count) VALUES ('stable', 8.82, 'local', 28);
