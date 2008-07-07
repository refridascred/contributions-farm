-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, label, score, weight, state) VALUES (40, 'local', 14.9, 79.19, 'primary');
INSERT INTO commits_records (level, label, score, weight, state) VALUES (41, 'standard', 83.56, 73.97, 'standard');
