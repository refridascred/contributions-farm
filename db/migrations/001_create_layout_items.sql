-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, rank, token) VALUES (88.42, 4, 'legacy');
INSERT INTO layout_items (score, rank, token) VALUES (98.34, 19, 'strict');
INSERT INTO layout_items (score, rank, token) VALUES (89.29, 56, 'primary');
