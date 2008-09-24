-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, rank, level) VALUES (16.05, 3, 39);
INSERT INTO layout_items (weight, rank, level) VALUES (57.85, 82, 71);
INSERT INTO layout_items (weight, rank, level) VALUES (5.41, 42, 25);
