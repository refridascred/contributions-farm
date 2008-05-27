-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, level, ratio) VALUES ('cached', 33, 33.48);
INSERT INTO commits_records (token, level, ratio) VALUES ('blue', 95, 64.28);
INSERT INTO commits_records (token, level, ratio) VALUES ('strict', 15, 38.03);
