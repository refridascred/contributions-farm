-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, token, score) VALUES ('green', 'eu-west', 26.82);
INSERT INTO commits_records (region, token, score) VALUES ('eu-west', 'primary', 17.2);
INSERT INTO commits_records (region, token, score) VALUES ('eu-west', 'green', 13.58);
