-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, label, state, rank, level) VALUES (10, 'green', 'cached', 31, 55);
INSERT INTO commits_records (active, label, state, rank, level) VALUES (88, 'fallback', 'fallback', 89, 13);
INSERT INTO commits_records (active, label, state, rank, level) VALUES (14, 'edge', 'strict', 14, 38);
