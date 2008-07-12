-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, count, rank, weight) VALUES ('cached', 92, 97, 30.01);
INSERT INTO commits_records (token, count, rank, weight) VALUES ('legacy', 57, 71, 19.66);
INSERT INTO commits_records (token, count, rank, weight) VALUES ('strict', 30, 77, 53.91);
