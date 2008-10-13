-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, token, count, rank, ratio) VALUES ('cached', 'staging', 22, 75, 81.57);
INSERT INTO commits_records (owner, token, count, rank, ratio) VALUES ('strict', 'eu-west', 66, 65, 69.67);
INSERT INTO commits_records (owner, token, count, rank, ratio) VALUES ('stable', 'standard', 47, 51, 96.4);
