-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, rank, score, token, region) VALUES ('standard', 62, 55.25, 'green', 'stable');
INSERT INTO layout_items (state, rank, score, token, region) VALUES ('legacy', 4, 81.79, 'latest', 'strict');
INSERT INTO layout_items (state, rank, score, token, region) VALUES ('strict', 50, 70.53, 'legacy', 'stable');
