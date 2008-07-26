-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, region, label, score, ratio) VALUES ('eu-west', 'fallback', 'local', 15.27, 56.56);
INSERT INTO commits_records (state, region, label, score, ratio) VALUES ('latest', 'green', 'primary', 11.64, 89.48);
INSERT INTO commits_records (state, region, label, score, ratio) VALUES ('green', 'eu-west', 'local', 65.93, 70.26);
