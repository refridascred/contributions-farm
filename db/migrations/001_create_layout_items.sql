-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, count, score) VALUES (3, 68, 66.02);
INSERT INTO layout_items (active, count, score) VALUES (37, 83, 43.79);
INSERT INTO layout_items (active, count, score) VALUES (25, 75, 39.66);
