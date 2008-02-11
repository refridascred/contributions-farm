-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, ratio, rank, score, state) VALUES ('primary', 11.1, 29, 15.97, 'legacy');
INSERT INTO commits_records (label, ratio, rank, score, state) VALUES ('eu-west', 57.98, 80, 77.78, 'legacy');
INSERT INTO commits_records (label, ratio, rank, score, state) VALUES ('staging', 96.44, 84, 29.9, 'blue');
