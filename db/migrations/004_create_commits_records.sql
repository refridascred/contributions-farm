-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, score, weight) VALUES ('cached', 6.3, 60.46);
INSERT INTO commits_records (token, score, weight) VALUES ('edge', 95.27, 19.51);
INSERT INTO commits_records (token, score, weight) VALUES ('eu-west', 81.85, 11.79);
