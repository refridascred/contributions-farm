-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, token, count, state, weight) VALUES ('open', 'primary', 89, 'edge', 6.96);
INSERT INTO commits_records (label, token, count, state, weight) VALUES ('edge', 'blue', 63, 'stable', 6.16);
