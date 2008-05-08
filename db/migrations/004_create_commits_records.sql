-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, owner, score, weight) VALUES ('eu-west', 'green', 42.46, 66.54);
INSERT INTO commits_records (label, owner, score, weight) VALUES ('strict', 'blue', 92.79, 34.74);
INSERT INTO commits_records (label, owner, score, weight) VALUES ('blue', 'local', 0.24, 86.96);
