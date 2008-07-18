-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, weight, owner, score, ratio) VALUES ('latest', 92.24, 'eu-west', 87.66, 25.68);
INSERT INTO commits_records (state, weight, owner, score, ratio) VALUES ('cached', 8.32, 'local', 83.05, 36.24);
