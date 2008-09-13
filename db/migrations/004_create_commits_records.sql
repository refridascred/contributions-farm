-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, score) VALUES ('open', 17.72);
INSERT INTO commits_records (owner, score) VALUES ('strict', 25.39);
INSERT INTO commits_records (owner, score) VALUES ('cached', 98.02);
