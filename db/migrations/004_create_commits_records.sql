-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, level, rank, score, region) VALUES ('cached', 22, 31, 11.1, 'fallback');
INSERT INTO commits_records (label, level, rank, score, region) VALUES ('eu-west', 27, 81, 51.75, 'blue');
INSERT INTO commits_records (label, level, rank, score, region) VALUES ('green', 80, 77, 41.64, 'cached');
