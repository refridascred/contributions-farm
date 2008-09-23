-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, score, state, owner) VALUES (4, 8.32, 'eu-west', 'stable');
INSERT INTO commits_records (level, score, state, owner) VALUES (0, 89.56, 'cached', 'staging');
INSERT INTO commits_records (level, score, state, owner) VALUES (69, 11.03, 'stable', 'edge');
