-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, active, state) VALUES (65, 34, 'open');
INSERT INTO commits_records (count, active, state) VALUES (63, 89, 'blue');
INSERT INTO commits_records (count, active, state) VALUES (41, 56, 'open');
