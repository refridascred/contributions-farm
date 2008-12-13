-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (weight, score, state, rank) VALUES (19.3, 1.26, 'local', 4);
INSERT INTO commits_records (weight, score, state, rank) VALUES (2.07, 45.73, 'strict', 97);
INSERT INTO commits_records (weight, score, state, rank) VALUES (35.45, 46.5, 'legacy', 75);
