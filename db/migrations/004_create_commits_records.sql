-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, weight, score, rank, state) VALUES ('stable', 25.46, 82.07, 10, 'edge');
INSERT INTO commits_records (label, weight, score, rank, state) VALUES ('fallback', 4.22, 26.38, 17, 'fallback');
INSERT INTO commits_records (label, weight, score, rank, state) VALUES ('standard', 6.08, 38.83, 8, 'legacy');
