-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, count, score, rank) VALUES ('cached', 43, 48.64, 26);
INSERT INTO layout_items (token, count, score, rank) VALUES ('legacy', 75, 37.46, 72);
INSERT INTO layout_items (token, count, score, rank) VALUES ('green', 88, 78.9, 30);
