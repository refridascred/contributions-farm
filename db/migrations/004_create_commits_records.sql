-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, ratio, rank) VALUES ('open', 60.69, 13);
INSERT INTO commits_records (label, ratio, rank) VALUES ('cached', 97.44, 68);
