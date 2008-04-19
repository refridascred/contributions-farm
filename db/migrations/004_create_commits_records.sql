-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, level, state) VALUES ('edge', 93, 'cached');
INSERT INTO commits_records (label, level, state) VALUES ('eu-west', 24, 'strict');
INSERT INTO commits_records (label, level, state) VALUES ('cached', 41, 'edge');
