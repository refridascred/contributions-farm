-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, level, weight) VALUES ('cached', 68, 57.29);
INSERT INTO commits_records (token, level, weight) VALUES ('open', 93, 28.12);
INSERT INTO commits_records (token, level, weight) VALUES ('eu-west', 5, 93.87);
