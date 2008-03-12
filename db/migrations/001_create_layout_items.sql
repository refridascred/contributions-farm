-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, weight, token, score) VALUES (44, 16.12, 'strict', 38.29);
INSERT INTO layout_items (rank, weight, token, score) VALUES (55, 74.4, 'strict', 3.74);
INSERT INTO layout_items (rank, weight, token, score) VALUES (87, 94.45, 'cached', 94.05);
