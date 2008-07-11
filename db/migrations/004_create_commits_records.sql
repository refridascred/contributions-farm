-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, score, weight) VALUES ('standard', 59.69, 43.59);
INSERT INTO commits_records (label, score, weight) VALUES ('local', 67.3, 55.81);
INSERT INTO commits_records (label, score, weight) VALUES ('staging', 77.21, 72.96);
