-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, weight, count, token, score) VALUES (64, 13.02, 24, 'standard', 42.48);
INSERT INTO layout_items (active, weight, count, token, score) VALUES (41, 9.63, 1, 'blue', 55.24);
