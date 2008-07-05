-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, score, level) VALUES ('cached', 23.4, 31);
INSERT INTO commits_records (label, score, level) VALUES ('open', 53.81, 14);
INSERT INTO commits_records (label, score, level) VALUES ('latest', 2.92, 18);
