-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, state, label) VALUES (82, 'latest', 'latest');
INSERT INTO commits_records (level, state, label) VALUES (49, 'strict', 'latest');
INSERT INTO commits_records (level, state, label) VALUES (4, 'cached', 'fallback');
