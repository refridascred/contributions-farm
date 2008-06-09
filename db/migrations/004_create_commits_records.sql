-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, label, state, active, level) VALUES (97, 'blue', 'staging', 89, 84);
INSERT INTO commits_records (count, label, state, active, level) VALUES (42, 'cached', 'blue', 0, 22);
INSERT INTO commits_records (count, label, state, active, level) VALUES (0, 'blue', 'open', 73, 38);
