-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, weight) VALUES (83, 95, 70.55);
INSERT INTO layout_items (level, rank, weight) VALUES (40, 37, 88.53);
INSERT INTO layout_items (level, rank, weight) VALUES (77, 52, 4.94);
