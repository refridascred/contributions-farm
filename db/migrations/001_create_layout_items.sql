-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, rank, level) VALUES (84, 11, 13);
INSERT INTO layout_items (count, rank, level) VALUES (51, 68, 29);
INSERT INTO layout_items (count, rank, level) VALUES (7, 21, 72);
