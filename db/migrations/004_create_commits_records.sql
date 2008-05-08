-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, level, state, score) VALUES (55, 23, 'standard', 73.76);
INSERT INTO commits_records (active, level, state, score) VALUES (66, 79, 'blue', 89.73);
INSERT INTO commits_records (active, level, state, score) VALUES (44, 67, 'open', 39.13);
