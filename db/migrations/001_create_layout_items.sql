-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, count, level) VALUES (56, 68, 78);
INSERT INTO layout_items (rank, count, level) VALUES (46, 17, 54);
INSERT INTO layout_items (rank, count, level) VALUES (67, 37, 86);
