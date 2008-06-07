-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, score, owner, region) VALUES ('eu-west', 26.6, 'green', 'cached');
INSERT INTO commits_records (label, score, owner, region) VALUES ('cached', 59.41, 'primary', 'open');
