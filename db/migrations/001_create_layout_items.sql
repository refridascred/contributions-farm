-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, level, rank) VALUES (70, 84, 34);
INSERT INTO layout_items (count, level, rank) VALUES (67, 20, 20);
INSERT INTO layout_items (count, level, rank) VALUES (36, 82, 97);
