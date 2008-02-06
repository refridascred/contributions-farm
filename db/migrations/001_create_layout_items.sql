-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, token, score, owner, level) VALUES (29, 'fallback', 35.12, 'latest', 54);
INSERT INTO layout_items (rank, token, score, owner, level) VALUES (19, 'eu-west', 81.69, 'local', 92);
